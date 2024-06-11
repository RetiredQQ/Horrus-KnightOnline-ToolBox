using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor.ExternalControl
{
    public class CustomPictureBox : PictureBox
    {
        public bool IsCreateNewItem { get; set; } = false;
        public bool IsDeleteItem { get; set; } = false;
        public int? SlotID { get; set; }

        public UserItem? ItemRepresentation { get; set; }

        public Image? OriginalIcon { get; set; }

    }
}
