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
		public List<string> replies = new List<string>();
		PostForm postObject;
		public Post(string inputPost)
		{
			string[] temp = inputPost.Split('|');
			post = temp[0];
			for (int ii = 1; ii < temp.Length; ii++)
			{
				replies.Add(temp[ii]);
			}
		}

		public Post()
		{
			post = "";
		}
		public string[] readPostFile()
		{
			string[] postFile = System.IO.File.ReadAllLines("post - Copy.txt");
			return postFile;
		}
	}
}
