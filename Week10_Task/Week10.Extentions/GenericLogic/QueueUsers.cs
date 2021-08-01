using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Week10.Extentions.GenericLogic
{
    public class QueueUsers
    {
        // create the Queue
        Queue userQueue = new Queue();

        public void AddUsers(string name, string phone, string email)
        {
            User localUser = new User();

            localUser.Name = name;
            localUser.PhoneNumber = phone;
            localUser.Email = email;
            //Enqueue
            userQueue.Enqueue(localUser);
        }

        public void RemoveUsers()
        {
            Queue<User> userQueue = new Queue<User>();


            int itemsBeforeDequeue = userQueue.Count;
            Console.WriteLine("Items before Dequeue {0}", itemsBeforeDequeue);

            User empOne = userQueue.Dequeue();
            Console.WriteLine(empOne.Name + " " + empOne.Name);

            int itemsAfterDequeue = userQueue.Count;
            Console.WriteLine("Items after first Dequeue {0}", itemsAfterDequeue);


            int itemsAfterFirstDequeue = userQueue.Count;
            Console.WriteLine("Items after second Dequeue {0}", itemsAfterFirstDequeue);

            foreach (User emp in userQueue)
            {
                Console.WriteLine(emp.PhoneNumber + " " + emp.Name);
            }
        }
    }
}
