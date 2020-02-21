using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Repo
{
    public class InsuranceRepo
    {
        private readonly Queue<ClaimContents> _contentDirectory = new Queue<ClaimContents>();

       public bool AddContentToDirectory(ClaimContents content)
        {
            int directoryLength = _contentDirectory.Count();
            _contentDirectory.Enqueue(content);
            bool wasAdded = directoryLength + 1 == _contentDirectory.Count();
            return wasAdded;
        }

        public Queue<ClaimContents> GetContents()
        {
            return _contentDirectory;
        }

        public ClaimContents PeekContent()
        {
            ClaimContents content = _contentDirectory.Peek();
            return content;
            //return a ClaimContents object
        }
        //peek method
        public void GetLastContent()   //dequeue method
        {
           _contentDirectory.Dequeue();
        }
    }
}
