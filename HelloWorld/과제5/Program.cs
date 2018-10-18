using System;
using System.Collections;
using System.Collections.Generic;

namespace 과제5
{
    class Goods
    {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga)
        {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override String ToString()
        {
            return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가="
                    + danga + "]";
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get; set; }

        public Cart(Goods Goods, int count, int sum)
        {
            this.goods = Goods;
            this.count = count;
            this.sum = sum;
        }

        public override String ToString()
        {
            return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum
                    + "]";
        }
    }

    class CartTest
    {
        static void Main()
        {
            Dictionary<int, Cart> re = new Dictionary<int, Cart>();
            re.Add(1,new Cart(new Goods(1001,"볼펜", 1000),2,2000));
            re.Add(2, new Cart(new Goods(1002, "연필", 1500), 3, 1500));
            re.Add(3, new Cart(new Goods(1003, "딸기", 6000), 2, 12000));

            foreach(KeyValuePair<int, Cart> d in re)
            {
                Console.WriteLine("{0}: {1}",d.Key,d.Value);
            }
        }
    }
}
