// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Learning.OOP.Dependency.Line
// {
//     public class Line
//     {
//         public Point Begin { get; set; }
//         public Point End { get; set; }

//         public Line(Point begin, Point end)
//         {
//             Begin = begin;
//             End = end;
//         }
//         public Line(int x1, int y1, int x2, int y2)
//         {
//             Begin = new Point(x1, y1);
//             End = new Point(x2, y2);
//         }

//         public double getLength()
//         {
//             return Math.sqrt(Math.pow(End.getX() - Begin.getX))
//         }
//     }
// }