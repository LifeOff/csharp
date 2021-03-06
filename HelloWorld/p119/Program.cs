﻿using System;
using System.Collections;
using System.Collections.Generic;


namespace p119
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String,String> onj = new Dictionary<string, string>();
            onj.Add("김길동", "서울");
            onj.Add("홍길동", "광주");
            onj.Add("박길동", "부산");

            try
            {
                onj.Add("김길동", "서울");
            }
            catch
            {
                Console.WriteLine("키값 중복");
            }
            Console.WriteLine("For key = \"name\", value = {0}", onj["홍길동"]);
            onj["박길동"] = "제주";
            Console.WriteLine("For key = \"name\", value = {0}", onj["박길동"]);

            if (!onj.ContainsKey("최길동")) // ContainsKey 키를 찾는 메소드
            {
                onj.Add("최길동", "하와이");
                Console.WriteLine("Value added for key = \"who\": {0}", onj["최길동"]);
            }
            Console.WriteLine();

            //출력순서를 확인하자.(입력된 순서로 나오는 것은 아님)
            foreach (KeyValuePair<string, string> d in onj) 
            {
                Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
            }

            SortedList s = new SortedList(onj); //해시테이블 정렬하기위해 SoretedList에 넣음

            foreach (DictionaryEntry d in s) //키값이 정렬된 형식으로 출력
            {
                Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
            }
        }
    }
}
