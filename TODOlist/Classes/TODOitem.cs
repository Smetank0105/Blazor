using System.Diagnostics.CodeAnalysis;

namespace TODOlist.Classes
{
    public class TODOitem : IComparable<TODOitem>, IEqualityComparer<TODOitem>
    {
        public string Title {  get; set; }
        public bool isDone { get; set; }
        public int CompareTo(TODOitem other)
        {
            return this.Title.CompareTo(other.Title);
        }
        public bool Equals(TODOitem left, TODOitem right)
        {
            return left.Title == right.Title;
        }
        public int GetHashCode(TODOitem other)
        {
            //return other.Title.GetHashCode();
            return HashCode.Combine(Title);
        }
    }
}
