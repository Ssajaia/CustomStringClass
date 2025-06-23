using System;

namespace DS
{
    public class Nstring
    {
        private string _val;
        private int size;

        public Nstring(string val)
        {
            _val = val;
            size = val.Length;
        }

        public static Nstring operator *(Nstring a, int num)
        {
            Nstring returnval = new Nstring("");
            for (int i = 0; i < num; i++)
            {
                returnval._val += a._val + '\n';
            }
            returnval.size = returnval._val.Length;
            return returnval;
        }
        private string Trim()
        {
            return _val.Trim();
        }
        public static Nstring operator +(Nstring a, Nstring b)
        {
            a.Trim();
            a._val += " ";
            b.Trim();
            a._val += b._val;

            a.size = a._val.Length;
            return a;
        }

        private Nstring Remove(int startIndex, int count)
        {
            if (startIndex >= 0 && count >= 0 && startIndex + count <= _val.Length)
            {
                _val = _val.Remove(startIndex, count);
                size = _val.Length;
            }
            return this;
        }

        public static Nstring operator -(Nstring a, Nstring b)
        {
            int index = a._val.IndexOf(b._val);
            if (index >= 0)
            {
                return a.Remove(index, b._val.Length);
            }
            return a;
        }

        public static int operator /(Nstring a, Nstring b)
        {
            int count = 0;
            int index = 0;
            while ((index = a._val.IndexOf(b._val, index)) != -1)
            {
                count++;
                index += b._val.Length;
            }
            return count;
        }

        public static Nstring operator ++(Nstring a)
        {
            char randChar = (char)new Random().Next('a', 'z' + 1);
            a._val += randChar;
            a.size = a._val.Length;
            return a;
        }

        public static Nstring operator --(Nstring a)
        {
            if (a._val.Length > 0)
            {
                a._val = a._val.Remove(a._val.Length - 1);
                a.size = a._val.Length;
            }
            return a;
        }

        public override string ToString()
        {
            return _val;
        }
        public static Nstring operator %(Nstring a, int num)
        {
            if (num <= 0) return new Nstring(a._val); 

            int rem = a._val.Length % num;
            string result = a._val.Substring(a._val.Length - rem, rem);
            return new Nstring(result);
        }
        public override bool Equals(object? obj)
        {
            if (obj is Nstring other)
                return _val == other._val;
            return false;
        }

        public override int GetHashCode()
        {
            return _val.GetHashCode();
        }
        public static bool operator ==(Nstring a, Nstring b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a._val == b._val;
        }

        public static bool operator !=(Nstring a, Nstring b)
        {
            return !(a == b);
        }

    }
}
