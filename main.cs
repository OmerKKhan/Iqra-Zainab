using System;

class Program {
 int palindronnum = 12121;
    int revrse, sum = 0;
    int temp;

    // Start is called before the first frame update
    void Start()
    {
        temp = palindronnum;

        while (palindronnum > 0)
        {
            revrse = palindronnum % 10;
            sum = (sum * 10) + revrse;
            palindronnum = palindronnum / 10;

        }
        if (temp == sum)
        {
            Debug.Log("palidrom");
        }
        else
            Debug.Log("not palindrom");
    }
  
}