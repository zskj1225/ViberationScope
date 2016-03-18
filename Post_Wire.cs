using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViberationScope
{
    public class Post_Wire
    {
        public Post thePost = new Post();
        public Wire theWire = new Wire();
    }
   
    public class Post
    {
        public float theta;
        public float H;
        public String type;
    }

    public class Wire
    {
        public float D;
        public float rho;
    }
}
