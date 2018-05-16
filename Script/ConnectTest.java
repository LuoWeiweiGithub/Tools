package org.sample;

import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.Callable;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.FutureTask;
import java.util.concurrent.atomic.AtomicReference;

public class ConnectTest {
	private final int reconnectPencent;
	private static int MAX_RETRY_TIMES = 3;
	private AtomicReference<FutureTask<Object>> connection = new AtomicReference<>();

	public ConnectTest(int pencent) {
		reconnectPencent = pencent;
	}

	private volatile Object conSync;
	private Object conSyncLocker = new Object();

	public void testAtomicConnect() {
		FutureTask<Object> task = connection.get();
		if (task == null) {
			task = reconnectAtomic(task);
		}

		int retry = 0;
		while (retry++ < MAX_RETRY_TIMES) {
			Object conn = getConnection(task);
			if (isDisconnected(conn)) {
				task = reconnectAtomic(task);
			} else {
				break;
			}
		}
	}

	public void testSyncConnect() {
		if (conSync == null) {
			synchronized (conSyncLocker) {
				if (conSync == null) {
					conSync = mockCreateConnect();
				}
			}
		}

		int retry = 0;
		while (retry++ < MAX_RETRY_TIMES) {
			if (isDisconnected(conSync)) {
				reconnectSync();
			} else {
				break;
			}
		}
	}

	private void reconnectSync() {
		synchronized (conSyncLocker) {
			conSync = mockCreateConnect();
		}
	}

	private FutureTask<Object> reconnectAtomic(FutureTask<Object> task) {
		FutureTask<Object> newTask = createFutureTask();
		FutureTask<Object> result;
		if (connection.compareAndSet(task, newTask)) {
			newTask.run();
			result = newTask;
		} else {
			result = connection.get();
		}
		return result;
	}

	private Object getConnection(FutureTask<Object> task) {
		try {
			return task.get();
		} catch (Exception e) {
			return null;
		}
	}

	private FutureTask<Object> createFutureTask() {
		return new FutureTask<>(new Callable<Object>() {

			@Override
			public Object call() throws Exception {
				return mockCreateConnect();
			}

		});
	}

	private Object mockCreateConnect() {
		try {
			Thread.sleep(100);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
		return new Object();
	}

	private boolean isDisconnected(Object conn) {
		int seed = (int) (Math.random() * 100);
		return conn == null || seed <= reconnectPencent;
	}

	public static void main(String[] args) throws Exception {
		// Options opt = new
		// OptionsBuilder().include(ConnectTest.class.getSimpleName()).forks(1).threads(4).build();
		//
		// new Runner(opt).run();
		int times = 10000;
		for (int percent = 0; percent <= 100; percent += 5) {
			for (int threadNum = 1; threadNum < 5; threadNum++) {
				ConnectTest connectTest = new ConnectTest(percent);
				List<Callable<Void>> atasks = connectTest.generateAtomicTasks(times);
				long start = System.nanoTime();
				connectTest.startTest(4, atasks);
				System.out.println(String.format("Atomic performance: %s; Thread num: %d; Reconnect Percent: %d",
						System.nanoTime() - start, threadNum, percent));
				List<Callable<Void>> stasks = connectTest.generateSyncTasks(times);
				long syncStart = System.nanoTime();
				connectTest.startTest(4, stasks);
				System.out.println(String.format("Sync   performance: %s; Thread num: %d; Reconnect Percent: %d",
						System.nanoTime() - syncStart, threadNum, percent));
			}
		}

	}

	private List<Callable<Void>> generateSyncTasks(int times) {
		List<Callable<Void>> result = new ArrayList<>();
		for (int i = 0; i < times; i++) {
			result.add(new Callable<Void>() {

				@Override
				public Void call() throws Exception {
					testSyncConnect();
					return null;
				}

			});
		}

		return result;
	}

	private List<Callable<Void>> generateAtomicTasks(int times) {
		List<Callable<Void>> result = new ArrayList<>();
		for (int i = 0; i < times; i++) {
			result.add(new Callable<Void>() {

				@Override
				public Void call() throws Exception {
					testAtomicConnect();
					return null;
				}

			});
		}

		return result;
	}

	private void startTest(int threadNum, List<Callable<Void>> tasks) throws InterruptedException {
		ExecutorService service = Executors.newFixedThreadPool(threadNum);
		service.invokeAll(tasks);
	}
}
