using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2test1
{
	public class Post
	{
		public string post;
		PostForm postObject;
		public Post(string inputPost)
		{
			post = inputPost;
		}
		public Post()
		{
			post = "";
		}
		public string[] readPostFile()
		{
			string[] postFile = System.IO.File.ReadAllLines("post.txt");
			return postFile;
		}
	}
}
