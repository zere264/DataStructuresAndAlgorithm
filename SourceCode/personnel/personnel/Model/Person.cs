using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel.Model
{
    /// <summary>
    /// 人员业务对象
    /// </summary>
    public class Person
    {
        public Guid ID { get; set; }           // 人员识别码
        public string Name { get; set; }       // 姓名
        public string Province { get; set; }   // 所在省份
        public string City { get; set; }       // 城市
        public bool Sex { get; set; }          // 性别
        public DateTime Birthday { get; set; } // 出生日期
        public string Email { get; set; }      // 电子邮件

        public Person()
        {
            this.ID = Guid.NewGuid();
        }
    }
}
