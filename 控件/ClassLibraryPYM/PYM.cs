using System.Text;

namespace ClassLibraryPYM
{
    public class PYM
    {
        private static string hz2py(string hz) //获得汉字的区位码 
        {
            byte[] sarr = Encoding.Default.GetBytes(hz);
            int len = sarr.Length;
            if (len > 1)
            {
                byte[] array = new byte[2];
                array = Encoding.Default.GetBytes(hz);

                int i1 = (short)(array[0] - '\0');
                int i2 = (short)(array[1] - '\0');

                //unicode解码方式下的汉字码 
                // array = System.Text.Encoding.Unicode.GetBytes(hz); 
                // int i1 = (short)(array[0] - '\0'); 
                // int i2 = (short)(array[1] - '\0'); 
                // int t1 = Convert.ToInt32(i1,16); 
                // int t2 = Convert.ToInt32(i2,16); 

                int tmp = i1 * 256 + i2;
                string getpychar = "*";//找不到拼音码的用*补位 

                if (tmp >= 45217 && tmp <= 45252) { getpychar = "A"; }
                else if (tmp >= 45253 && tmp <= 45760) { getpychar = "B"; }
                else if (tmp >= 47761 && tmp <= 46317) { getpychar = "C"; }
                else if (tmp >= 46318 && tmp <= 46825) { getpychar = "D"; }
                else if (tmp >= 46826 && tmp <= 47009) { getpychar = "E"; }
                else if (tmp >= 47010 && tmp <= 47296) { getpychar = "F"; }
                else if (tmp >= 47297 && tmp <= 47613) { getpychar = "G"; }
                else if (tmp >= 47614 && tmp <= 48118) { getpychar = "H"; }
                else if (tmp >= 48119 && tmp <= 49061) { getpychar = "J"; }
                else if (tmp >= 49062 && tmp <= 49323) { getpychar = "K"; }
                else if (tmp >= 49324 && tmp <= 49895) { getpychar = "L"; }
                else if (tmp >= 49896 && tmp <= 50370) { getpychar = "M"; }
                else if (tmp >= 50371 && tmp <= 50613) { getpychar = "N"; }
                else if (tmp >= 50614 && tmp <= 50621) { getpychar = "O"; }
                else if (tmp >= 50622 && tmp <= 50905) { getpychar = "P"; }
                else if (tmp >= 50906 && tmp <= 51386) { getpychar = "Q"; }
                else if (tmp >= 51387 && tmp <= 51445) { getpychar = "R"; }
                else if (tmp >= 51446 && tmp <= 52217) { getpychar = "S"; }
                else if (tmp >= 52218 && tmp <= 52697) { getpychar = "T"; }
                else if (tmp >= 52698 && tmp <= 52979) { getpychar = "W"; }
                else if (tmp >= 52980 && tmp <= 53640) { getpychar = "X"; }
                else if (tmp >= 53689 && tmp <= 54480) { getpychar = "Y"; }
                else if (tmp >= 54481 && tmp <= 55289) { getpychar = "Z"; }
                return getpychar;
            }
            if (hz == "0" || hz == "1" || hz == "2" || hz == "3" || hz == "4" || hz == "5" || hz == "6" || hz == "7" || hz == "8" || hz == "9")
            {
                return "*";
            }
            return hz;
        }

        public static string transpy(string strhz) //把汉字字符串转换成拼音码 
        {
            string strtemp = "";
            int strlen = strhz.Length;
            for (int i = 0; i <= strlen - 1; i++)
            {
                strtemp += hz2py(strhz.Substring(i, 1));
            }
            return strtemp;
        }
    }
}
