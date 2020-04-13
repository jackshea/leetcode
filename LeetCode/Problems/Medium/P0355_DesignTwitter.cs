using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 设计推特
    /// https://leetcode-cn.com/problems/design-twitter/
    public class Twitter
    {
        Dictionary<int, LinkedList<Message>> msgManager = new Dictionary<int, LinkedList<Message>>();
        Dictionary<int, HashSet<int>> focus = new Dictionary<int, HashSet<int>>();

        /** Initialize your data structure here. */
        public Twitter()
        {

        }

        /** Compose a new tweet. */
        public void PostTweet(int userId, int tweetId)
        {
            if (!msgManager.ContainsKey(userId))
            {
                msgManager.Add(userId, new LinkedList<Message>());
            }

            msgManager[userId].AddFirst(new Message(tweetId));
            if (msgManager[userId].Count > 10)
            {
                msgManager[userId].RemoveLast();
            }
        }

        /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
        public IList<int> GetNewsFeed(int userId)
        {
            List<int> news = new List<int>();
            Follow(userId, userId);
            var followees = focus[userId];
            List<Message> msg = new List<Message>();
            foreach (var followee in followees)
            {
                if (!msgManager.ContainsKey(followee))
                {
                    continue;
                }
                msg.AddRange(msgManager[followee]);
            }
            msg.Sort((a, b) => -a.Time.CompareTo(b.Time));
            List<int> ans = new List<int>(10);
            for (int i = 0; i < 10 && i < msg.Count; i++)
            {
                ans.Add(msg[i].MessageId);
            }

            return ans;
        }

        /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
        public void Follow(int followerId, int followeeId)
        {
            if (!focus.ContainsKey(followerId))
            {
                focus[followerId] = new HashSet<int>();
            }

            focus[followerId].Add(followeeId);
        }

        /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
        public void Unfollow(int followerId, int followeeId)
        {
            if (!focus.ContainsKey(followerId))
            {
                return;
            }

            focus[followerId].Remove(followeeId);
        }
    }

    public class Message
    {
        private static int TimeGenerator = 0;

        public int MessageId { get; private set; }
        public int Time { get; private set; }

        public Message(int messageId)
        {
            MessageId = messageId;
            Time = TimeGenerator++;
        }
    }
}