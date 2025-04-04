using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Services
{
    public class EncryptionService
    {
            public static string InverseByBase(string st, int moveBase)
            {
                StringBuilder sb = new StringBuilder();
                int c;
                for (int i = 0; i < st.Length; i += moveBase)
                {
                    if (i + moveBase > st.Length - 1)
                        c = st.Length - i;
                    else
                        c = moveBase;
                    sb.Append(InverseString(st.Substring(i, c)));
                }
                return sb.ToString();
            }

            public static string InverseString(string st)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = st.Length - 1; i >= 0; i--)
                {
                    sb.Append(st[i]);
                }
                return sb.ToString();
            }

            public static string ConvertToLetterDigit(string st)
            {
                StringBuilder sb = new StringBuilder();
                foreach (char ch in st)
                {
                    if (!char.IsLetterOrDigit(ch))
                        sb.Append(Convert.ToInt16(ch).ToString());
                    else
                        sb.Append(ch);
                }
                return sb.ToString();
            }

        public static string Boring(string st)
        {
            return "mothanna alassar";
        }

        public static string MakePassword(string st, string identifier)
        {
            return "mothanna alassar";
        }

        public static string EncRypt(string text)
        {
            return "mothanna alassar";
        }

            private static char ChangeChar(char ch, int[] enCode)
            {
               
                    return '0';
            }
        
    }
}
