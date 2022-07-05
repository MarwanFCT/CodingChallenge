package com.mycompany.codingchallengejava;

import java.math.BigInteger;

/**
 *
 * @author oukha
 */
public class CodingChallengeJava {

    public static BigInteger N = new BigInteger("100000");

    public static void main(String[] args) throws InterruptedException {
        System.out.printf("The input number is %d the ouput is %d \n the timelapse is  %.3f ms ", N, Fibonacci(N), GetTimeLapse());
    }

    public static BigInteger Fibonacci(BigInteger n) {
        BigInteger previousValue = new BigInteger("-1");
        BigInteger currentResult = new BigInteger("1");

        for (int i = 0; i <= n.intValue(); ++i) {
            BigInteger sum = currentResult.add(previousValue);
            previousValue = currentResult;
            currentResult = sum;
        }

        return currentResult;
    }

    public static float GetTimeLapse() throws InterruptedException {
        long startTime = System.nanoTime();

        Fibonacci(N);

        long endTime = System.nanoTime();
       
        long timeElapsed = endTime - startTime;

        return timeElapsed / 1000000;
    }

}
