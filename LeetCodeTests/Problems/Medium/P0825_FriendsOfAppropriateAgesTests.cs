using System;
using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0825_FriendsOfAppropriateAgesTests
{
    [Test]
    public void NumFriendRequestsTest()
    {
        var test = new P0825_FriendsOfAppropriateAges();
        var input = new[] { 16, 16 };
        Assert.AreEqual(2, test.NumFriendRequests(input));
    }

    [Test]
    public void NumFriendRequestsTest_1()
    {
        var test = new P0825_FriendsOfAppropriateAges();
        var input = new[] { 16, 17, 18 };
        Assert.AreEqual(2, test.NumFriendRequests(input));
    }

    [Test]
    public void NumFriendRequestsTest_2()
    {
        var test = new P0825_FriendsOfAppropriateAges();
        var input = new[] { 20, 30, 100, 110, 120 };
        Assert.AreEqual(3, test.NumFriendRequests(input));
    }

    [Test]
    public void NumFriendRequestsTest_3()
    {
        var test = new P0825_FriendsOfAppropriateAges();
        var input = new[] { 73, 106, 39, 6, 26, 15, 30, 100, 71, 35, 46, 112, 6, 60, 110 };
        Array.Sort(input);
        Assert.AreEqual(29, test.NumFriendRequests(input));
    }

    [Test]
    public void NumFriendRequestsTest_4()
    {
        var test = new P0825_FriendsOfAppropriateAges();
        var input = new[] { 118, 14, 7, 63, 103 };
        Array.Sort(input);
        Assert.AreEqual(2, test.NumFriendRequests(input));
    }
}