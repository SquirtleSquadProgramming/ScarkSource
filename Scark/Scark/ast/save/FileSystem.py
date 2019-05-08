import json
import os
from random import *

class FileSystem:

    # encode is for encoding letters as numbers
    def encode(data):
        numData = [0] * len(data)
        for x in range(len(data)):
            numData[x] = data[x].replace("a", "1").replace("b", "2").replace("c", "3").replace("d", "4").replace("e", "5").replace("f", "6").replace("g", "7").replace("h", "8").replace("i", "9").replace("j", "9").replace("k", "10").replace("l", "11").replace("m", "12").replace("n", "13").replace("o", "14").replace("p", "15").replace("q", "16").replace("r", "17").replace("s", "18").replace("t", "19").replace("u", "20").replace("v", "21").replace("w", "22").replace("x", "23").replace("y", "24").replace("z", "25").replace("'", "26").replace("\"", "27").replace(":", "28").replace("{", "29").replace("}", "30").replace(" ", "").replace("A", "100").replace("B", "101").replace("C", "102").replace("D", "103").replace("E", "104").replace("F", "105").replace("G", "106").replace("H", "107").replace("I", "108").replace("J", "109").replace("K", "110").replace("L", "111").replace("M", "112").replace("N", "113").replace("O", "114").replace("P", "115").replace("Q", "116").replace("R", "117").replace("S", "118").replace("T", "119").replace("U", "120").replace("V", "121").replace("W", "122").replace("X", "123").replace("Y", "124").replace("Z", "125")

        output = ""
        for x in range(len(numData)):
            while len(numData[x]) < 3:
                numData[x] = "0"

        return numData

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
