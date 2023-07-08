﻿using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using Random = Unity.Mathematics.Random;

[BurstCompile]
public static class RandomFiller
{
    [BurstCompile]
    public static void FillArrayFloat(ref NativeArray<float> outArray)
    {
        Random rand = new Random(191919);
        
        for (int i = 0; i < outArray.Length; i++)
        {
            outArray[i] = rand.NextFloat();
        }
    }
    
    [BurstCompile]
    public static void FillArrayFloat3(ref NativeArray<float3> outArray)
    {
        Random rand = new Random(191919);
        
        for (int i = 0; i < outArray.Length; i++)
        {
            outArray[i] = rand.NextFloat3();
        }
    }
    
    
    public static void FillArrayFloat3(ref float3[] outArray)
    {
        Random rand = new Random(191919);
        
        for (int i = 0; i < outArray.Length; i++)
        {
            outArray[i] = rand.NextFloat3();
        }
    }
    
    public static void FillArrayFloat3(ref Vector3[] outArray)
    {
        Random rand = new Random(191919);
        
        for (int i = 0; i < outArray.Length; i++)
        {
            outArray[i] = rand.NextFloat3();
        }
    }
}