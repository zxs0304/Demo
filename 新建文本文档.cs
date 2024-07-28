using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Text;

public class Solution
{

    //88
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = m; i < nums1.Length; i++)
        {
            nums1[i] = nums2[i - m];
        }

        Array.Sort(nums2);

    }
    static void Main(string[] args)
    {
        

    }
}