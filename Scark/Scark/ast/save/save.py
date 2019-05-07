import json
import os
from random import *

class FileSystem:

    # encode is for encoding letters as numbers
    def encode(data):
        numData = [0] * len(data)
        for x in range(len(data)):
            numData[x] = data[x].replace("a", "0").replace("b", "1").replace("c", "2").replace("d", "3").replace("e", "4").replace("f", "5").replace("g", "6").replace("h", "7").replace("i", "8").replace("j", "9").replace("k", "10").replace("l", "11").replace("m", "12").replace("n", "13").replace("o", "14").replace("p", "15").replace("q", "16").replace("r", "17").replace("s", "18").replace("t", "19").replace("u", "20").replace("v", "21").replace("w", "22").replace("x", "23").replace("y", "24").replace("z", "25").replace("'", "26").replace("\"", "27").replace(":", "28").replace("{", "29").replace("}", "30").replace(" ", "")
        print(numData)

    # writeTF function is for writing to selected file with given data
    def writeTF(fnm, dtw):
        # opening the file that is in the same folder in write mode
        f = open(str(os.path.dirname(os.path.realpath(__file__)) + "\\" + fnm + ".save"), "w+")
        f.write(dtw) # writing to the file

    # readFF function is for reading from selected file
    def readFF(fnm):
        # opening the file that is in the same folder in write mode
        f = open(str(os.path.dirname(os.path.realpath(__file__)) + "\\" + fnm + ".save"), "r")
        return f.read() # writing to the file
