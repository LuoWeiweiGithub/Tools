using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetGithub
{
    public class ExecutorEnumerator : IEnumerator<AbstractExecutor>
    {
        private DirectoryExecutor root;
        private AbstractExecutor current;
        public ExecutorEnumerator(DirectoryExecutor directoryExcutor)
        {
            current = directoryExcutor;
            root = directoryExcutor;
            AddCurrentDirectory();
        }

        public AbstractExecutor Current
        {
            get
            {
                return GetCurrent();
            }
        }

        private LinkedList<DirectoryExecutor> directoryExecutor = new LinkedList<DirectoryExecutor>();
        private Tuple<LinkedListNode<DirectoryExecutor>, IEnumerator<AbstractExecutor>> executorCursor;

        private AbstractExecutor GetCurrent()
        {
            AbstractExecutor result = current;

            if (executorCursor != null)
            {
                if (!executorCursor.Item2.MoveNext())
                {
                    directoryExecutor.Remove(executorCursor.Item1);
                    executorCursor = null;
                }
            }

            if (executorCursor == null)
            {
                while (directoryExecutor.Count > 0)
                {
                    var executor = directoryExecutor.First;
                    executor.Value.Execute();
                    IEnumerator<AbstractExecutor> executorEnumerator = executor.Value.Executors.GetEnumerator();

                    if (executorEnumerator.MoveNext())
                    {
                        executorCursor = new Tuple<LinkedListNode<DirectoryExecutor>, IEnumerator<AbstractExecutor>>(
                            executor, executorEnumerator);
                        break;
                    }
                    else
                        directoryExecutor.Remove(executor);
                }
            }

            if (executorCursor == null)
                current = null;
            else
                current = executorCursor.Item2.Current;

            AddCurrentDirectory();

            return result;
        }

        private void AddCurrentDirectory()
        {
            DirectoryExecutor executor = current as DirectoryExecutor;
            if (executor != null)
                directoryExecutor.AddLast(executor);
        }

        object IEnumerator.Current
        {
            get
            {
                return GetCurrent();
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return current != null;
        }

        public void Reset()
        {
            current = root;
        }
    }
}
