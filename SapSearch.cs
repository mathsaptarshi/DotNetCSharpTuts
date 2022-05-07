namespace doNetCSharpTut
{
    internal class SapSearch
    {
        internal SapSearch()
        {

        }
        public bool LinearSearchOnInt(int[] myArr,int searchValue,out int position)
        {
            for (int i = 0; i < myArr.Length; i++)
            {
                if(myArr[i] == searchValue)
                {
                    position = i;
                    return true;
                }
                else
                {
                    position = -1;
                    continue;

                }
            }
            position = -1;
            return false;
        }
    }
}