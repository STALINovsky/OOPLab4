using System.Collections.Generic;

namespace OOPLab4.View.Interfaces
{
    public interface IInputService
    {
        public List<int> GetArrayOfNumbers();
        public int GetNumber();
        bool IsUserAgree();
    }
}
