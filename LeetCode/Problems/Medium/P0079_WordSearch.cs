﻿namespace LeetCode.Problems.Medium;

/// 单词搜索
/// https://leetcode-cn.com/problems/word-search/
public class P0079_WordSearch
{
    private readonly int[] dc = { 0, 1, 0, -1 };
    private readonly int[] dr = { 1, 0, -1, 0 };
    private char[][] board;
    private string word;

    public bool Exist(char[][] board, string word)
    {
        this.word = word;
        this.board = board;
        for (var i = 0; i < board.Length; i++)
        for (var j = 0; j < board[0].Length; j++)
            if (DFS(i, j, 0))
                return true;

        return false;
    }

    private bool DFS(int r, int c, int index)
    {
        if (index >= word.Length) return false;

        if (r < 0 || r >= board.Length || c < 0 || c >= board[0].Length) return false;

        if (index == word.Length - 1 && board[r][c] == word[index]) return true;

        if (board[r][c] != word[index]) return false;

        var old = board[r][c];
        board[r][c] = ' ';
        for (var i = 0; i < dr.Length; i++)
            if (DFS(r + dr[i], c + dc[i], index + 1))
                return true;
        board[r][c] = old;

        return false;
    }
}