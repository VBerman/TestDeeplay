using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeeplay.Shared.Models.Post;
using TestDeeplay.Shared.Models.PostKey;

namespace TestDeeplay.Shared.Models.PostValue
{
    public class PostValueEntity
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Value { get; set; }

        public int KeyId { get; set; }

        public int PostId { get; set; }

        public virtual PostKeyEntity Key { get; set; }
        public virtual PostEntity Post { get; set; }

    }
}
