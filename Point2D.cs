using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240718_ClassesDemo
{
    public class Point2D
    {
        const int DEFAULT_X_COORDINATE = 100;
        const int DEFAULT_Y_COORDINATE = 75;


        #region ---===   Data   ===---

        private int _x = DEFAULT_X_COORDINATE;
        private int _y = DEFAULT_Y_COORDINATE;

        private static int _instanceCount = 0;

        #endregion

        #region ---===   ctors   ===---

        public Point2D()
        {
            _instanceCount += 1;
        }

        public Point2D(int coord) 
                : this(coord, coord)    // call Point2D(int x, int y)
        {
            //_x = coord;
            //_y = coord;
        }

        public Point2D(int x, int y)
        {
            _x = x;
            _y = y;

            _instanceCount += 1;
        }

        ~Point2D()
        {
            Console.WriteLine($"dtor{this}");
        }

        #endregion

        #region ---===   Methods / member functions   ===---

        public int GetX()
        {
            return _x;
        }

        public void SetX(int x)
        {
            // validation
            if (x < 0)
            {
                return;
            }

           _x = x;
        }

        public int GetY()
        {
            return _y;
        }

        public void SetY(int y)
        {
            // validation
            if (y < 0)
            {
                return;
            }

            // <field> = <param>
            _y = y;
        }

        public static int GetInstanceCount()
        {
            // this no access

            return _instanceCount;
        }

        public static int InstanceCount
        {
            get
            {
                return _instanceCount;
            }
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                // validation
                if (value < 0)
                {
                    return;
                }

                _x = value;
            }
        }

        // read only property
        public int Vector
        {
            get
            {
                return _x * _y;
            }
        }

        #endregion

        #region ####    Point2D --> string    ####

        public override string ToString()
        {
            return $"({_x}, {_y})";
        }

        #endregion

    }
}
