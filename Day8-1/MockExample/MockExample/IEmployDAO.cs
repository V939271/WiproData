namespace MockExample
{
    public interface IEmployDAO
    {
        List<Employ> ShowEmploy();
        Employ SearchEmploy(int empno);
    }
}