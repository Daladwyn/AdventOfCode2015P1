﻿using System;

namespace AdventOfCode2015p1
{
    class Program
    {
        static void Main(string[] args)
        {
            var whatFloorIsSantaNow = 0;

            var whatInstructionGoesToBasement = 0;
            var havePassedFirstFloorInBasement = false;
            var directions = "(((())))()((((((((())()(()))(()((((()(()(((()((()((()(()()()()()))(((()(()((((((((((())(()()((())()(((())))()(()(()((()(()))(()()()()((()((()(((()()(((((((()()())()((((()()(((((()(())()(())((())()()))()(((((((())(()())(()(((())(()))((())))(()((()())))()())((((())))(()(((((()(())(((()()((()((()((((((((((())(()())))))()))())()()((((()()()()()()((((((())())(((()())()((()()(((()()()))(((((()))(((()(()()()(()(()(((())()))(()(((()((())()(()())())))((()()()(()()(((()))(((()((((()(((((()()(()())((()())())(()((((((()(()()))((((()))))())((())()()((()(()))))((((((((()))(()()(((())())(())()((()()()()((()((()((()()(((())))(()((())()((((((((()((()(()()(((())())())))(())())))()((((()))))))())))()()))()())((()())()((()()()))(()()(((()(())((((())())((((((((()()()()())))()()()((((()()))))))()((((()(((()))(()()())))((()()(((()))()()())())(((())((()()(())()()()(((())))))()())((()))()))((())()()())()())()()(()))())))())()))(())((()(())))(()(())(()))))(()(())())(()(())(()(()))))((()())()))()((((()()))))())))()()())((())()((()()()))()(((()(()))))(())()()))(((()())))))))))(((())))()))())()))))()()(((())))))))()(()()(()))((()))))((())))((()((())))())))()()(()))())()(()((()())(()(()()())())(()()))()))))(()())()()))()()()()))(()(()(()))))))()(()))()))()()(()((())(()(())))()(((())(())())))))()(()(()))))()))(()()()(())()(()(())))()))))()()(((((())))))())()())())())()())()))))()))))))))())()()()()()()())))()))((())()))())))()((())()))))()))())))))))())()()()))()()(()((((()(((((((()(())((()())((()()))()))))(())))()()()(())((())()())))(())))(())))(((()()))()(())(((()(()))((())))())()))((((()))())()))))))))()(())())))(()))()(()()))())()()(())())))())()()(()())))()((()())(()(())(())))))))))))))(()))))()))))))()()())(()(((((()(()())))())()))(()))()))(()()))()())(()))())()(())((()()))))))())))())()(((())))(()(()))()()))()(()))))))((()())(()))))))()())))()()))))))))((((((((()()()(()))))))()())))())))()()((())()))((())(())))())())))()()()((()((()(())))())()(())))))))))()())))()()()()()()))()))((())())(()(()))))))(()()))()))(())))()))))))))))))(()))))))))()))))()))()())()))()()))))))()))))((()))))(()))())()(())))(()())((((()())))()))))(()))()(()()(())))))())))))()))))))())))())))))())))())())))())(()))))(())()(())))())()))((()()))))))())))((())))))))())))(())))))()()())))))())))))()))))))()))()()()(()(((()())())())(()))())))))((()(())(()))))))))(())))()()()())())(()))))()()()))()))())())())()(())))()(((()((((())))))))()))))))))))))))))))))((())()())(()))))()()))))))(()()(())())))())))((())))((())))))))))))))()))))()(()))))))())))))()))(()()())(()())))))))))()))))))(())))))()()))()())(((())))()))(()))))))))(())())))())))())())())()()))((())()(())()())()))()())(())(()))))()())))(()(((()))))))()(()())()()()))()))))))))()()()(())()())()(((((()))()())())(()))))()()()(())))())))()((()())))(()))())()(()())())(()))()()))((()()))((()()()()())))(())()))(()(())))((()()))))))))())))))))())()()))))))))))))))))(())()(())(())()())())()))()(()))))())())))))()())()(()))()()(())))(())())))))(()))))))))))))))())())(())(())))(((()))()))))())((())(()))())))))))())))))())))()))()))))))))))))())()))))()))))((()))(())))()(())))(())()))()))())))())))))))()(()())())))()()())))(())))))(()))))))))))))(()))()))()))())))(((()()()(())((()())))()())(((()))(())()))((()()()())))())(())(()))))()(((((())))(()))())())))))))((((()()()))())())()(()(()())))))))))()())())))(())))()())(((()(())())()()))())())))))))((()())((()()(()))(()(())))()))()))(()))(()))()()(()(((())((((()))()(()))((())()(()(()())()(()))()())))))(()))()))())()())))())))(())))((())(()())))))()))(())(()))()())()(()()((()(()))))))()(())(()())(())()))(((())()))(()()(()()()))))(()(())))()))))())))))())(()()()()()()(((())))(()()))()((())(((((()()())))(()))(()))()()))(((())())()(((()()()()))))(()))(())())))()())(()()())())))))))()))))((())))()())(()))(()(()))())))))())(())))))()()())())()))()()(())))(()))(())((((((())(()))(()))())()))(()()(())))()))(()()))()))()(())))(())))((()(()))(())()()())())))(((()()())(())()))))))()(((()(((((()()(((())(())))())()((()))))((()())()(())(((())))(((()((()(()(()))(()()))())(()))(())(())))()))))))((((()))()((((()(()))()))()()))))()(()(()))()(()((()(((()(()()(((()))))()(((()(()(()(((()(()())())()()(()(()())())(()((((())(()))()))(((((()()())(())()((()()())))()()(((()()))()((((((((()(())))())((()))))(())))(()))))((()((((()()(())(((((()))(((((((((((((()())))((((()(((()((())())()))((()))()(()()((()()()()(()()(()(()(((())()(()((((((()((()()((())()((((()((()()(()()())((()()()((()((())()(()(((()((())((((())(()))((()(()))(()())()((((((((()(((((((((((()))(()(((()(()()()((((())((())()())()))(())((())(()))(((()((()(())))(()))))((()()))))((((()(()(()())(()(())((((((((()((((()((()(((((()))())()(()))(()()((()(())(((((()(())()(((((()()))))))()(((())()(()()((((())()((())((()(((())(((()))((()()((((()(())))))((()((((()((()((()(((())((()))(((((((()(((()((((((((())()))((((())(((((()((((((((()(((()((()(((()()(((()((((((()()(()((((((((()()(()(()(())((((()())()))))(((()))((((())((((()())((()(())()((()((((((()((((((()(())))()())(((())())())()(())()(()())((()()((((())((((((())(()(((((()((((())()((((()(()(())(()())(((())()((())((((()))()((((((())(()(((()(((()((((((()(((()))(()()())())((()((()())()((((())(((()(()(((((((((())(())))()((()()()()(())((()))(((((((()(((((((((()(()))))(()((((((((()((((()((()()((((((()()(((((((()(()(())()(())((()()()((()(((((()())()(((((()())()()((()(()())(()()()(((()()(((((()((((((()()((()(()()()((((((((((((()((((((((()()(((()())))()(((()()(())())((((()((((()((((()()()(())(())((()(()(((((((((((((((()(())(())))))()()))((()(((()(())((()(((()(()()((((()()(((()(((()(((((()()((()(()(((()))((((((()((((((((()((()((())(((((()(((())(())())((()()))((((())()()((()(((()(((((()()(((()))(((()(()(((((((((((((()))((((((((()(((()))))())((((((((((((())((())((()())(((())((())(()((((((((((()(((())((()()(()((())(((((((((((()))((((((((((((()(()())((()((()((()(()(((()((((((((()()(()((()(()(((()))((()))(((((((((((((()(())((((((())(((()(())(()(()(()((()()))((((()((((()((((())))())((((()((((()))((((((()((((((()((()(((())))((())(()))(()((()((((()((()(((()()))((((()()()(((((((())(((())(()))())((((()())(((()(((((((((((()(()(()((()(((((((((((((((()()((((()((((((((()(((()()((()((((()))(((()(())((((((()((((())()((((()((()))(())()(()(((()((())())((((((()(()(())())(((())(()(()())(((((()((()((())()())(())))(((()(())))))))(((()(((()))()((()(((()()((()())()()))())))(((()))(()(((()(((((((((()(()(((((()()(((()())()()))))()(((()))(((()(()(()(()(()))()(())()))(()(((())))(()))))))))))(())((()((())((()(())()(())((()()((((()()((()()))((())(((()((()(())(())))()(()(((((()((()))())()(((((()()(((()(()((((((())(()))(())()))((()(()()))(())())()))(((())))(()((()(((())(())())))((()()((((((((((((((()((()(()()(()(((()))())()()((()()()(())(()))(()())(((())((())()(())()()(()()(())))((()(((()))))(((()()(()()))())((()((())()))((((()()()())((())))(((()(())(((((()(((((()((()(()((((()()(((()()()(((()())(((()()((((())(()))(((()))(())())((()))(((()((()))(((()()((())((()(((((()((((()()())((()))()((((()((()(()()()(";
            var instructionString = directions;

            for (int i = 0; i < instructionString.Length; i++)
            {
                var sign = Convert.ToString(instructionString[i]);
                switch (sign)
                {
                    case "(":
                        whatFloorIsSantaNow++;
                        break;
                    case ")":
                        whatFloorIsSantaNow--;
                        break;
                    default:
                        break;
                }
                if ((havePassedFirstFloorInBasement == false) && (whatFloorIsSantaNow == -1))
                {
                    havePassedFirstFloorInBasement = true;
                    whatInstructionGoesToBasement = i + 1;
                }
            }
            Console.WriteLine("Instructions is taking Santa to floor:{0}",whatFloorIsSantaNow);
            Console.WriteLine("First instruction that takes Santa to basement:{0}",whatInstructionGoesToBasement);
        }
    }
}