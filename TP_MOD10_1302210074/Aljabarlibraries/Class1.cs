namespace Aljabarlibraries
{
    public class Class1
    {
        public static int FPB(int input1, int input2)
        {
            int mod_result;
            while (input2 != 0)
            {
                mod_result = input1 % input2;
                input1 = input2;
                input2 = mod_result;
            }
            return input1;
        }
        public static int KPK(int input1, int input2)
        {
            int mult_input1 = input1;
            int mult_input2 = input2;
            while (input1 != input2)
            {
                while (input1 > input2)
                {
                    input2 += mult_input2;
                }
                while (input1 < input2)
                {
                    input1 += mult_input1;
                }
            }
            return input1;
        }

        public static String Turunan(int[] persamaan)
        {
            String result = "";
            for (int i = 0, pangkat = persamaan.Length - i - 1; i < persamaan.Length - 2; i++, pangkat--)
            {
                int first_num = persamaan[i] * pangkat;
                result += (first_num == 1 ? null : (first_num).ToString("+#;-#;0")) + "x" + (pangkat - 1 == 1 ? null : (pangkat - 1));
            }
            return (result[0].ToString() == "+" || result[0].ToString() == "-" ? result.Substring(1) : result) + persamaan[^2].ToString("+#;-#;0");
        }

        public static String Integral(int[] persamaan)
        {
            String result = "";
            for (int i = 0, pangkat = persamaan.Length - i - 1; i < persamaan.Length; i++, pangkat--)
            {
                int first_num = persamaan[i] / (pangkat + 1);
                result += (first_num == 1 ? null : first_num.ToString("+#;-#;0")) + "x" + (i == persamaan.Length - 1 ? null : (pangkat + 1));
            }
            return (result[0].ToString() == "+" || result[0].ToString() == "-" ? result.Substring(1) : result) + "+C";
        }
    }
}