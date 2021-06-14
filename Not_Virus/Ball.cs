﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Not_Virus
{
    class Ball
    {

        private int _x;
        private int _y;
        private int _width;
        private int _height;
        private int _xSpeed;
        private int _ySpeed;
        private Pen _pen;
        private static int _formWidth;
        private static int _formHeight;

        public Ball(int x, int y, int formWidth, int formHeight, int xSpeed, int ySpeed, Color color, int width, int height)
        {
            _x = x;
            _y = y;
            _xSpeed = xSpeed;
            _ySpeed = ySpeed;
            _formWidth = formWidth;
            _formHeight = formHeight;
            _pen = new Pen(color);
            _width = width;
            _height = height;
        }

        public int formWidth
        {
            set { _formWidth = value; }
        }

        public int formHeight
        {
            set { _formHeight = value; }
        }

        public Color color
        {
            set { _pen = new Pen(value); }
        }

        public void Draw(Graphics gr)
        {
            _x += _xSpeed;
            _y += _ySpeed;

            if ((_x + _width) >= _formWidth)
            {
                _xSpeed *= -1;
                _x = _formWidth - _width;
            }
            if (_x <= 0)
            {
                _xSpeed *= -1;
                _x = 1;
            }

            if ((_y + _height) >= _formHeight)
            {
                _ySpeed *= -1;
                _y = _formHeight - _height;
            }
            if (_y <= 0)
            {
                _ySpeed *= -1;
                _y = 1;
            }

            gr.DrawEllipse(_pen, _x, _y, _width, _height);

        }

    }
}
