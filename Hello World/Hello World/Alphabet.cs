namespace Hello_World
{
    public class Alphabet
    {
        public static char cHarbet(int aInput)
        {
            char[] cAlphabet = new char[26];
            cAlphabet[0] = 'a';
            cAlphabet[1] = 'b';
            cAlphabet[2] = 'c';
            cAlphabet[3] = 'd';
            cAlphabet[4] = 'e';
            cAlphabet[5] = 'f';
            cAlphabet[6] = 'g';
            cAlphabet[7] = 'h';
            cAlphabet[8] = 'i';
            cAlphabet[9] = 'j';
            cAlphabet[10] = 'k';
            cAlphabet[11] = 'l';
            cAlphabet[12] = 'm';
            cAlphabet[13] = 'n';
            cAlphabet[14] = 'o';
            cAlphabet[15] = 'p';
            cAlphabet[16] = 'q';
            cAlphabet[17] = 'r';
            cAlphabet[18] = 's';
            cAlphabet[19] = 't';
            cAlphabet[20] = 'u';
            cAlphabet[21] = 'v';
            cAlphabet[22] = 'w';
            cAlphabet[23] = 'x';
            cAlphabet[24] = 'y';
            cAlphabet[25] = 'z';
            return (cAlphabet[aInput]);
        }
    }

    public class Numbers
    {
        public static char cNumbers(int nInput)
                {
                    char[] cNumbers = new char[10];
                    cNumbers[0] = '0';
                    cNumbers[1] = '1';
                    cNumbers[2] = '2';
                    cNumbers[3] = '3';
                    cNumbers[4] = '4';
                    cNumbers[5] = '5';
                    cNumbers[6] = '6';
                    cNumbers[7] = '7';
                    cNumbers[8] = '8';
                    cNumbers[9] = '9';
                    return (cNumbers[nInput]);
                }
    }
}