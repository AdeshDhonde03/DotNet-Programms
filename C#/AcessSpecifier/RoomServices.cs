using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessSpecifier
{
    internal class RoomServices
    {
        protected internal string GetRoomType()
        {
            return "PG";
        }
        public string GetRoomName()
        {
            return "Paint";
        }
    }
}
