using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeeplay.Shared.Models.Post;
using TestDeeplay.Shared.Models.PostValue;

namespace TestDeeplay.Shared.Models.PostKey
{
    public class PostKeyEntity
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Key { get; set; }
        
        public virtual ICollection<PostValueEntity> Values { get; set; } 
        
    }
}
