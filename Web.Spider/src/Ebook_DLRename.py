import os
import string
from time import time
from pathlib import Path
from pathlib import PurePath

mapfilePath = "/Users/DyllanLuo//MyDocuments/log/ebook-dl_output.txt"
dirPath = "/Users/DyllanLuo//MyDocuments/log/test/"
valid_chars = "-_.() %s%s" % (string.ascii_letters, string.digits)

fileName = {}

def readMapFile():
    with open(mapfilePath, 'r', encoding='utf-8') as mapFile:
        for line in mapFile:
            index = line.find('\t')
            key = line[0: index]
            extensionIndex = key.rfind('.')
            extension = key[extensionIndex:]
            value = line[index + 1 : ].rstrip() + extension
            fileName[key] = value

def replaceInDir(udir):
    p = Path(udir)
    for x in p.iterdir():
        if (x.is_dir()):
            replaceInDir(x)
        else:
            replaceFile(x)

def replaceFile(file):
    file = str(file)
    pure = PurePath(file)
    name = pure.name
    if '(www.ebook-dl.com)' in name:
        newFileName = name.replace('_', ' ')
    else:
        newFileName = fileName.get(name)
    if newFileName is not None and newFileName != '':
        newFileName = ''.join(c for c in newFileName if c in valid_chars)
        newPath = str(pure.parent) + '/' + newFileName
        os.renames(file, newPath)
        print (newPath)

readMapFile()
replaceInDir(dirPath)