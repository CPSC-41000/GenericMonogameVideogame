//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CTrie
//{
//    public sealed class CNode : MainNode
//    {
//        int bmp;
//        Array array;
//    }

//    public sealed class SNode : MainNode
//    {
//        Key key;
//        Value value;
//        bool tomb;
//    }

//    public class MainNode
//    {
//    }

//    public class INode
//    {
//        MainNode mainNode;
//    }


//    public class CTrie
//    {
//        INode root;

//        public CTrie()
//        {
//        }

//        void Insert(Key k, Value v)
//        {
//            if (root == null)
//            {
//                CNode scan = CNode(k, v);

//            }
//            else
//            {
//                root.Insert(k, v);
//            }
//        }

//    }
//}
