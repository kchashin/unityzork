namespace zork.common
{
    public interface IOutputService
    {
        void WriteLine(string value);
        void WriteLine(object value);
        void Clear();
        void Write(string value);
        void Write(object value);



    }
}
