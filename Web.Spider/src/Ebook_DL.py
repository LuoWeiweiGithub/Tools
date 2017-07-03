import re
import logging
import urllib.request
from functools import partial
from multiprocessing.pool import Pool
from time import time

roothost = "http://www.ebook-dl.com"
targetFilePath = "/Users/DyllanLuo//MyDocuments/log/ebook-dl_output.txt"

target = logging.getLogger('log')
target.setLevel(logging.INFO)
targetAppend = logging.FileHandler(targetFilePath)
targetAppend.setFormatter(logging.Formatter('%(message)s'))
target.addHandler(targetAppend)

linksRe = re.compile("http-equiv\s*=\s*\"refresh\"\s+content\s*=\s*\"[^\"]+\"")

path = roothost + "/downloadbook/%d"

def ayanyzeData(data, url):
    try:
        result = linksRe.findall(data)
        result = list(result)
        link = result.pop(0)
        startIndex = link.find("url=")
        link = link[startIndex + 4: -1]
        printLog(roothost + link)
    except:
        printLog("error:" + url)
        
def printLog(log):
    print(log)
    target.info(log)
    
def downloadUrl(url):
    try:
        req = urllib.request.Request(url, method="GET")
        print("Requesting: " + url)
        with urllib.request.urlopen(req) as resp:
            if resp.status == 200:
                print('info: http status 200: ' + url)
                data1 = resp.read()
                data1 = data1.decode('utf-8')
                ayanyzeData(data1, url)
            else:
                printLog('error: http status %d: %s' % (resp.status, url)) 
    except:
        printLog("error: " + url)
ts = time()
links = [path % i for i in range(8000, 9000)]
download = partial(downloadUrl)
with Pool(16) as pool:
    pool.map(download, links)

print('Took {}s'.format(time() - ts))
print('Done')