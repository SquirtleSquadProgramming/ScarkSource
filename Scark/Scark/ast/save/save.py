import json
import os
from random import *

class FileSystem:

    # encode is for encoding letters as numbers
    def enocde(data):
        numData = [] * len(list(data))
        for x in len(list(data)):
            numData[x] = data[x].replace("a", 0).replace("b", 1).replace("c", 2).replace("d", 3).replace("e", 4).replace("f", 5).replace("g", 6).replace("h", 7).replace("i", 8).replace("j", 9).replace("k", 10).replace("l", 11).replace("m", 12).replace("n", 13).replace("o", 14).replace("p", 15).replace("q", 16).replace("r", 17).replace("s", 18).replace("t", 19).replace("u", 20).replace("v", 21).replace("w", 22).replace("x", 23).replace("y", 24).replace("z", 25)

    # write function is for writing the character data that is " encrytped " into a file
    def write(characterInformation, name):
        characterInformation = str(characterInformation)
        gened = randint(6000, 9999) # how much to multiply x by
        tmplist = [""] * 68 # creating temp list for numbers
        max = len(str(int(gened * 68))) # max length of the highest number
        for x in range(68):
            tmplist[x] = str(int(x * gened))
            while len(tmplist[x]) < max:
                tmplist[x] = "0{}".format(tmplist[x])

        output = str(characterInformation).replace("a", tmplist[0]).replace("b", tmplist[1]).replace("c", tmplist[2]).replace("d", tmplist[3]).replace("e", tmplist[4]).replace("f", tmplist[5]).replace("g", tmplist[6]).replace("h", tmplist[7]).replace("i", tmplist[8]).replace("j", tmplist[9]).replace("k", tmplist[10]).replace("l", tmplist[11]).replace("m", tmplist[12]).replace("n", tmplist[13]).replace("o", tmplist[14]).replace("p", tmplist[15]).replace("q", tmplist[16]).replace("r", tmplist[17]).replace("s", tmplist[18]).replace("t", tmplist[19]).replace("u", tmplist[20]).replace("v", tmplist[21]).replace("w", tmplist[22]).replace("x", tmplist[23]).replace("y", tmplist[24]).replace("z", tmplist[25]).replace("1", tmplist[26]).replace("2", tmplist[27]).replace("3", tmplist[28]).replace("4", tmplist[29]).replace("5", tmplist[30]).replace("6", tmplist[31]).replace("7", tmplist[32]).replace("8", tmplist[33]).replace("9", tmplist[34]).replace("0", tmplist[35]).replace("'", tmplist[36]).replace("\"", tmplist[37]).replace(",", tmplist[38]).replace("{", tmplist[39]).replace("}", tmplist[40]).replace(":", tmplist[41]).replace(" ", "").replace("A", tmplist[42]).replace("B", tmplist[43]).replace("C", tmplist[44]).replace("D", tmplist[45]).replace("E", tmplist[46]).replace("F", tmplist[47]).replace("G", tmplist[48]).replace("H", tmplist[49]).replace("I", tmplist[50]).replace("J", tmplist[51]).replace("K", tmplist[52]).replace("L", tmplist[53]).replace("M", tmplist[54]).replace("N", tmplist[55]).replace("O", tmplist[56]).replace("P", tmplist[57]).replace("Q", tmplist[58]).replace("R", tmplist[59]).replace("S", tmplist[60]).replace("T", tmplist[61]).replace("U", tmplist[62]).replace("V", tmplist[63]).replace("W", tmplist[64]).replace("X", tmplist[65]).replace("Y", tmplist[66]).replace("Z", tmplist[67])

        FileSystem.writeTF(name, output)
        print(output)

    # writeTF function is for writing to selected file with given data
    def writeTF(fnm, dtw):
        # opening the file that is in the same folder in write mode
        f = open(str(os.path.dirname(os.path.realpath(__file__)) + "\\" + fnm + ".save"), "w+")
        f.write(dtw) # writing to the file

    # readFF function is for reading from selected file
    def readFF(fnm):
        # opening the file that is in the same folder in write mode
        f = open(str(os.path.dirname(os.path.realpath(__file__)) + "\\" + fnm + ".save"), "w+")
        f.write(dtw) # writing to the file
