//*****************************************************************************
//** 2938. Separate Black and White Balls    leetcode                        **
//*****************************************************************************


long long minimumSteps(char* s) {
    long long res = 0;
    long long swaps = 0;
    int len = strlen(s);

    for (int i = 0; i < len; i++)
    {
        if (s[i] == '1')
        {
            swaps++;
        }
        else
        {
            res += swaps;
        }
    }

    return res;
}