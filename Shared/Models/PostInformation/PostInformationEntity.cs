using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDeeplay.Shared.Models.Post;

namespace TestDeeplay.Shared.Models.PostInformation
{
    public class PostInformationEntity
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Key { get; set; }
        [MaxLength(150)]
        public string Value { get; set; }
        public ICollection<PostEntity> Posts { get; set; }
    }
}
