﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JollyPirate.model
{
    class Boat
    {
        private string Type;
        private int Length;
        private readonly string Id;

        public Boat(string type, int length, string id)
        {
            Type = type;
            Length = length;
            Id = id;
        }

        public string getType()
        {
            return Type;
        }

        public void setType(string newType)
        {
            Type = newType;
        }

        public int getLength()
        {
            return Length;
        }

        public void setLength(int newLength)
        {
            Length = newLength;
        }

        public string GetId()
        {
            return Id;
        }

        public override string ToString()
        {
            return "Boat of type: " + Type + " with length: " + Length.ToString() + ". ID: " + Id;
        }

    }
}
