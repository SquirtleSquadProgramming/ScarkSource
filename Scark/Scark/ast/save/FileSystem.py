import json
import os
from random import *
import math

class FileSystem:

    def save(data):
        writeTF(data[3], encode(data), "save")

    def readCharacter(name):
        return json.loads("{'save':" + decode(readFF(name, "save")) + "}")

    # encode is for encoding letters as numbers
    def encode(data):
        encDec = FileSystem.readFF("encdec", "list").split("\n")

        loopNum = 0
        while loopNum < len(encDec):
            if ">" not in encDec[loopNum]:
                encDec.pop(loopNum)
                loopNum = loopNum - 1
            else:
                encDec[loopNum] = encDec[loopNum].split(">")
            loopNum = loopNum + 1

        for x in range(len(encDec)):
            data = data.replace(encDec[x][0], encDec[x][1])

        return data

    # decode is for encoding letters as numbers
    def decode(data):
        encDec = FileSystem.readFF("encdec", "list").split("\n")

        loopNum = 0
        while loopNum < len(encDec):
            if ">" not in encDec[loopNum]:
                encDec.pop(loopNum)
                loopNum = loopNum - 1
            else:
                encDec[loopNum] = encDec[loopNum].split(">")
            loopNum = loopNum + 1

        data = [data[i:i+3] for i in range(0, len(data), 3)]
        output = ""

        for x in range(len(data)):
            for y in range(len(encDec)):
                if encDec[y][1] in data[x]:
                    output += data[x].replace(encDec[y][1], encDec[y][0])

        return output

    # writeTF function is for writing to selected file with given data
    def writeTF(fnm, dtw, filetype):
        # opening the file that is in the same folder in write mode
        f = open(str(os.path.dirname(os.path.realpath(__file__)) + "\\" + fnm + "." + filetype), "w+")
        f.write(dtw) # writing to the file

    # readFF function is for reading from selected file
    def readFF(fnm, filetype):
        # opening the file that is in the same folder in write mode
        f = open(str(os.path.dirname(os.path.realpath(__file__)) + "\\" + fnm + "." + filetype), "r")
        return f.read() # writing to the file
