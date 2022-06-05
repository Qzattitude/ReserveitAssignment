using System;
using System.Collections;
using System.Collections.Generic;

namespace ReserveitAssignment.Controllers
{
    public class LineConstructorRepository : ILineConstructorRepository
    {
        public static ArrayList line = new();
        public void LineConstructorRepositiry(int minLength, List<string> text)
        {
            //ArrayList line = new ArrayList();
            var lineOfSize = "";

            for (var i = 0; i < text.Count; i++)
            {
                lineOfSize = text[i];
                if (minLength == text[i].Length)
                {
                    line.Add(text[i]);
                }
                else if (minLength > text[i].Length)
                {
                    var vacant = minLength - text[i].Length;

                    for (var j = 0; j < text.Count; j++)
                    {
                        if (text[j].Length == vacant)
                        {
                            //operation
                            ///lineOfSize = String.Concat(lineOfSize, text[j]);
                            var temp = String.Concat(lineOfSize, " ");
                            line.Add(String.Concat(temp, text[j]));
                            temp = "";
                        }
                        else if (text[j].Length < vacant)
                        {
                            //operation
                            //lineOfSize = String.Concat(lineOfSize, text[j]);
                            var temp2 = String.Concat(lineOfSize, " ");
                            line.Add(String.Concat(temp2, text[j]));
                            temp2 = "";
                        }
                    }

                }

            }
        }

        public ArrayList GetLines()
        {
            return line;
        }
    }
}
