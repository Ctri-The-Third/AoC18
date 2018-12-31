using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC18_core_v3.DayXCode
{
    public class Day4
    {
        //public static string DefaultProblem = "[1518-11-01 00:00] Guard #10 begins shift\r\n[1518-11-01 00:05] falls asleep\r\n[1518-11-01 00:25] wakes up\r\n[1518-11-01 00:30] falls asleep\r\n[1518-11-01 00:55] wakes up\r\n[1518-11-01 23:58] Guard #99 begins shift\r\n[1518-11-02 00:40] falls asleep\r\n[1518-11-02 00:50] wakes up\r\n[1518-11-03 00:05] Guard #10 begins shift\r\n[1518-11-03 00:24] falls asleep\r\n[1518-11-03 00:29] wakes up\r\n[1518-11-04 00:02] Guard #99 begins shift\r\n[1518-11-04 00:36] falls asleep\r\n[1518-11-04 00:46] wakes up\r\n[1518-11-05 00:03] Guard #99 begins shift\r\n[1518-11-05 00:45] falls asleep\r\n[1518-11-05 00:55] wakes up";
        public static string DefaultProblem = "[1518-05-30 00:27] wakes up\r\n[1518-11-02 00:00] Guard #433 begins shift\r\n[1518-07-05 23:56] Guard #2593 begins shift\r\n[1518-03-31 00:55] falls asleep\r\n[1518-06-20 00:17] falls asleep\r\n[1518-09-10 00:00] Guard #277 begins shift\r\n[1518-11-14 00:39] falls asleep\r\n[1518-09-08 23:59] Guard #1709 begins shift\r\n[1518-08-23 00:35] falls asleep\r\n[1518-06-03 00:46] wakes up\r\n[1518-02-27 00:59] wakes up\r\n[1518-03-18 00:10] falls asleep\r\n[1518-09-28 00:49] wakes up\r\n[1518-05-19 00:55] wakes up\r\n[1518-03-20 00:42] wakes up\r\n[1518-06-03 00:00] Guard #1871 begins shift\r\n[1518-07-04 00:38] wakes up\r\n[1518-06-08 00:32] wakes up\r\n[1518-08-13 00:04] Guard #1871 begins shift\r\n[1518-05-24 00:00] Guard #739 begins shift\r\n[1518-03-02 00:03] Guard #103 begins shift\r\n[1518-04-09 00:44] wakes up\r\n[1518-08-27 00:22] falls asleep\r\n[1518-11-07 00:50] wakes up\r\n[1518-05-30 00:16] falls asleep\r\n[1518-09-12 00:49] wakes up\r\n[1518-02-17 00:38] falls asleep\r\n[1518-10-05 00:49] wakes up\r\n[1518-05-28 00:01] falls asleep\r\n[1518-03-31 00:52] wakes up\r\n[1518-07-01 23:57] Guard #1051 begins shift\r\n[1518-11-02 00:21] falls asleep\r\n[1518-08-03 00:59] wakes up\r\n[1518-03-15 00:57] falls asleep\r\n[1518-08-20 00:34] falls asleep\r\n[1518-08-19 00:59] wakes up\r\n[1518-02-24 00:15] falls asleep\r\n[1518-02-16 00:28] falls asleep\r\n[1518-08-21 00:00] Guard #2251 begins shift\r\n[1518-08-02 00:49] falls asleep\r\n[1518-03-16 00:26] falls asleep\r\n[1518-05-31 00:30] falls asleep\r\n[1518-06-19 00:46] falls asleep\r\n[1518-08-12 00:58] wakes up\r\n[1518-10-31 00:53] falls asleep\r\n[1518-02-23 00:54] wakes up\r\n[1518-11-04 00:44] wakes up\r\n[1518-07-12 00:00] Guard #239 begins shift\r\n[1518-07-05 00:51] falls asleep\r\n[1518-08-28 00:55] wakes up\r\n[1518-03-13 00:00] Guard #727 begins shift\r\n[1518-04-13 00:49] falls asleep\r\n[1518-07-29 00:32] falls asleep\r\n[1518-07-30 23:56] Guard #277 begins shift\r\n[1518-03-26 00:46] falls asleep\r\n[1518-11-21 00:03] Guard #1447 begins shift\r\n[1518-11-14 00:04] falls asleep\r\n[1518-09-09 00:55] wakes up\r\n[1518-03-16 00:03] Guard #727 begins shift\r\n[1518-05-08 23:46] Guard #1249 begins shift\r\n[1518-06-28 00:53] wakes up\r\n[1518-06-04 00:32] wakes up\r\n[1518-10-08 00:55] wakes up\r\n[1518-02-23 00:14] falls asleep\r\n[1518-11-04 00:11] falls asleep\r\n[1518-03-14 00:49] wakes up\r\n[1518-11-19 00:02] Guard #1171 begins shift\r\n[1518-11-01 00:12] wakes up\r\n[1518-09-29 00:58] wakes up\r\n[1518-10-02 00:56] wakes up\r\n[1518-07-26 00:39] wakes up\r\n[1518-10-13 00:59] wakes up\r\n[1518-09-23 00:57] wakes up\r\n[1518-03-14 00:59] wakes up\r\n[1518-07-19 00:54] wakes up\r\n[1518-05-03 00:57] wakes up\r\n[1518-02-24 00:57] wakes up\r\n[1518-10-03 00:41] falls asleep\r\n[1518-08-09 00:03] Guard #2423 begins shift\r\n[1518-09-05 00:40] wakes up\r\n[1518-10-29 00:23] falls asleep\r\n[1518-09-26 00:03] Guard #239 begins shift\r\n[1518-10-31 00:32] falls asleep\r\n[1518-04-13 00:18] falls asleep\r\n[1518-10-02 00:12] falls asleep\r\n[1518-06-11 00:54] falls asleep\r\n[1518-05-21 00:38] falls asleep\r\n[1518-09-18 00:59] wakes up\r\n[1518-04-16 00:00] Guard #433 begins shift\r\n[1518-09-20 00:47] wakes up\r\n[1518-09-20 00:52] falls asleep\r\n[1518-09-19 00:32] falls asleep\r\n[1518-10-26 00:30] falls asleep\r\n[1518-06-21 00:44] falls asleep\r\n[1518-10-23 00:01] Guard #1249 begins shift\r\n[1518-06-15 23:56] Guard #2689 begins shift\r\n[1518-04-19 00:04] falls asleep\r\n[1518-09-29 00:35] falls asleep\r\n[1518-04-18 00:53] wakes up\r\n[1518-11-15 00:29] falls asleep\r\n[1518-06-05 00:58] wakes up\r\n[1518-10-15 00:56] falls asleep\r\n[1518-04-24 00:00] falls asleep\r\n[1518-09-06 23:48] Guard #2689 begins shift\r\n[1518-08-25 00:47] falls asleep\r\n[1518-03-27 00:00] falls asleep\r\n[1518-11-13 23:53] Guard #1097 begins shift\r\n[1518-03-14 00:08] falls asleep\r\n[1518-04-02 00:52] wakes up\r\n[1518-06-20 00:58] wakes up\r\n[1518-02-24 00:40] falls asleep\r\n[1518-09-07 00:04] falls asleep\r\n[1518-04-20 00:03] Guard #2593 begins shift\r\n[1518-04-29 00:57] wakes up\r\n[1518-10-13 00:29] falls asleep\r\n[1518-08-18 00:19] falls asleep\r\n[1518-02-27 00:46] wakes up\r\n[1518-03-30 00:15] falls asleep\r\n[1518-05-23 00:40] wakes up\r\n[1518-02-22 00:56] falls asleep\r\n[1518-06-28 00:35] falls asleep\r\n[1518-06-11 00:48] wakes up\r\n[1518-03-22 23:56] Guard #433 begins shift\r\n[1518-04-02 23:58] Guard #2251 begins shift\r\n[1518-07-24 23:58] Guard #2593 begins shift\r\n[1518-09-22 00:13] falls asleep\r\n[1518-10-06 00:17] falls asleep\r\n[1518-10-26 00:00] Guard #109 begins shift\r\n[1518-09-20 00:24] falls asleep\r\n[1518-03-06 00:39] falls asleep\r\n[1518-07-02 00:45] wakes up\r\n[1518-06-30 00:44] falls asleep\r\n[1518-11-12 23:59] Guard #2251 begins shift\r\n[1518-05-31 00:54] wakes up\r\n[1518-06-30 00:56] wakes up\r\n[1518-11-07 00:15] wakes up\r\n[1518-04-09 23:50] Guard #103 begins shift\r\n[1518-03-23 00:34] wakes up\r\n[1518-06-27 00:59] wakes up\r\n[1518-03-08 00:43] falls asleep\r\n[1518-03-03 00:54] wakes up\r\n[1518-04-07 00:14] falls asleep\r\n[1518-11-10 00:43] wakes up\r\n[1518-09-30 00:52] wakes up\r\n[1518-11-21 00:58] wakes up\r\n[1518-05-18 00:39] falls asleep\r\n[1518-03-09 23:57] Guard #1871 begins shift\r\n[1518-05-05 00:46] falls asleep\r\n[1518-03-25 00:46] wakes up\r\n[1518-04-23 00:28] falls asleep\r\n[1518-06-19 00:54] wakes up\r\n[1518-08-28 23:58] Guard #1447 begins shift\r\n[1518-04-20 00:53] wakes up\r\n[1518-04-05 00:51] wakes up\r\n[1518-04-18 23:50] Guard #2423 begins shift\r\n[1518-02-28 23:56] Guard #677 begins shift\r\n[1518-09-06 00:02] Guard #1097 begins shift\r\n[1518-09-30 00:45] wakes up\r\n[1518-08-15 00:07] falls asleep\r\n[1518-10-10 00:04] Guard #1051 begins shift\r\n[1518-10-16 00:38] wakes up\r\n[1518-07-02 00:41] falls asleep\r\n[1518-06-11 00:56] wakes up\r\n[1518-10-14 00:13] falls asleep\r\n[1518-05-06 00:32] wakes up\r\n[1518-10-04 00:42] wakes up\r\n[1518-09-05 00:12] falls asleep\r\n[1518-05-03 00:55] falls asleep\r\n[1518-11-15 00:18] falls asleep\r\n[1518-08-11 00:02] Guard #103 begins shift\r\n[1518-05-08 00:40] falls asleep\r\n[1518-08-19 00:53] wakes up\r\n[1518-08-06 23:57] Guard #2887 begins shift\r\n[1518-05-08 00:04] Guard #2251 begins shift\r\n[1518-11-18 00:27] falls asleep\r\n[1518-04-01 00:26] falls asleep\r\n[1518-03-28 00:28] wakes up\r\n[1518-05-02 00:28] falls asleep\r\n[1518-10-01 00:26] falls asleep\r\n[1518-07-28 00:59] wakes up\r\n[1518-07-15 00:00] Guard #727 begins shift\r\n[1518-07-10 00:49] falls asleep\r\n[1518-07-26 00:12] falls asleep\r\n[1518-07-13 00:01] falls asleep\r\n[1518-08-25 00:57] wakes up\r\n[1518-09-26 23:52] Guard #2593 begins shift\r\n[1518-11-22 23:59] Guard #1097 begins shift\r\n[1518-09-21 00:44] wakes up\r\n[1518-07-24 00:51] wakes up\r\n[1518-10-24 00:24] falls asleep\r\n[1518-09-25 00:00] Guard #109 begins shift\r\n[1518-09-16 00:01] Guard #1709 begins shift\r\n[1518-08-19 00:56] falls asleep\r\n[1518-09-29 00:54] wakes up\r\n[1518-08-01 00:00] Guard #239 begins shift\r\n[1518-06-22 00:31] falls asleep\r\n[1518-11-11 00:01] falls asleep\r\n[1518-07-27 00:01] Guard #2887 begins shift\r\n[1518-03-15 00:45] wakes up\r\n[1518-03-04 00:26] falls asleep\r\n[1518-03-10 00:50] falls asleep\r\n[1518-02-21 00:17] wakes up\r\n[1518-10-19 00:14] falls asleep\r\n[1518-10-02 23:57] Guard #739 begins shift\r\n[1518-05-16 00:02] Guard #727 begins shift\r\n[1518-05-05 00:30] falls asleep\r\n[1518-08-17 23:56] Guard #109 begins shift\r\n[1518-04-14 00:51] falls asleep\r\n[1518-05-18 00:22] wakes up\r\n[1518-04-01 00:57] wakes up\r\n[1518-10-14 00:02] Guard #2251 begins shift\r\n[1518-09-03 00:47] wakes up\r\n[1518-08-23 00:02] Guard #433 begins shift\r\n[1518-05-04 00:52] falls asleep\r\n[1518-02-18 00:57] wakes up\r\n[1518-06-12 00:00] Guard #727 begins shift\r\n[1518-06-03 23:59] Guard #433 begins shift\r\n[1518-05-02 23:59] Guard #2251 begins shift\r\n[1518-09-10 00:25] falls asleep\r\n[1518-06-06 00:01] Guard #2423 begins shift\r\n[1518-10-15 00:28] wakes up\r\n[1518-07-18 00:37] falls asleep\r\n[1518-04-09 00:00] Guard #2887 begins shift\r\n[1518-08-04 00:01] Guard #2423 begins shift\r\n[1518-07-21 00:19] falls asleep\r\n[1518-08-08 00:40] wakes up\r\n[1518-07-14 00:49] wakes up\r\n[1518-07-01 00:54] wakes up\r\n[1518-04-16 00:33] falls asleep\r\n[1518-08-03 00:43] wakes up\r\n[1518-10-17 00:24] falls asleep\r\n[1518-09-04 00:03] falls asleep\r\n[1518-10-22 00:58] wakes up\r\n[1518-11-05 00:37] wakes up\r\n[1518-06-09 00:01] Guard #677 begins shift\r\n[1518-09-27 00:22] falls asleep\r\n[1518-04-23 00:47] wakes up\r\n[1518-03-14 23:51] Guard #2689 begins shift\r\n[1518-04-21 00:38] falls asleep\r\n[1518-05-13 00:54] wakes up\r\n[1518-05-26 00:40] falls asleep\r\n[1518-07-05 00:00] Guard #2423 begins shift\r\n[1518-04-16 23:58] Guard #2423 begins shift\r\n[1518-06-15 00:59] wakes up\r\n[1518-11-02 00:23] wakes up\r\n[1518-05-27 23:53] Guard #1871 begins shift\r\n[1518-09-26 00:20] falls asleep\r\n[1518-03-30 00:38] wakes up\r\n[1518-04-02 00:26] falls asleep\r\n[1518-02-27 00:04] Guard #1171 begins shift\r\n[1518-02-19 00:34] wakes up\r\n[1518-08-10 00:32] falls asleep\r\n[1518-08-30 00:01] Guard #1447 begins shift\r\n[1518-08-26 00:02] Guard #727 begins shift\r\n[1518-11-14 00:48] wakes up\r\n[1518-04-17 00:37] wakes up\r\n[1518-04-25 00:56] wakes up\r\n[1518-06-27 00:41] falls asleep\r\n[1518-07-16 00:40] falls asleep\r\n[1518-08-01 00:08] falls asleep\r\n[1518-08-08 00:30] falls asleep\r\n[1518-03-16 00:57] wakes up\r\n[1518-07-07 00:42] wakes up\r\n[1518-08-27 00:10] falls asleep\r\n[1518-02-23 00:42] falls asleep\r\n[1518-04-10 00:35] falls asleep\r\n[1518-11-11 00:39] wakes up\r\n[1518-07-03 00:47] wakes up\r\n[1518-11-07 00:12] falls asleep\r\n[1518-07-11 00:46] falls asleep\r\n[1518-09-07 00:53] wakes up\r\n[1518-05-26 00:18] falls asleep\r\n[1518-07-10 00:57] wakes up\r\n[1518-03-17 00:02] Guard #109 begins shift\r\n[1518-04-27 00:14] falls asleep\r\n[1518-09-23 00:12] wakes up\r\n[1518-07-10 00:05] falls asleep\r\n[1518-08-06 00:38] falls asleep\r\n[1518-07-15 23:59] Guard #677 begins shift\r\n[1518-09-14 23:50] Guard #2251 begins shift\r\n[1518-04-29 00:49] falls asleep\r\n[1518-09-05 00:03] Guard #2689 begins shift\r\n[1518-11-17 00:50] wakes up\r\n[1518-04-20 00:56] falls asleep\r\n[1518-02-21 00:08] falls asleep\r\n[1518-08-20 00:56] wakes up\r\n[1518-03-07 00:32] wakes up\r\n[1518-07-15 00:18] falls asleep\r\n[1518-05-14 00:43] wakes up\r\n[1518-07-12 00:59] wakes up\r\n[1518-10-30 00:34] falls asleep\r\n[1518-10-23 00:56] wakes up\r\n[1518-02-23 00:25] wakes up\r\n[1518-03-12 00:08] falls asleep\r\n[1518-08-21 00:37] wakes up\r\n[1518-06-20 23:56] Guard #2689 begins shift\r\n[1518-06-22 00:42] falls asleep\r\n[1518-06-04 00:54] falls asleep\r\n[1518-05-22 00:31] falls asleep\r\n[1518-04-25 00:02] Guard #1097 begins shift\r\n[1518-03-03 00:31] falls asleep\r\n[1518-08-16 00:49] wakes up\r\n[1518-11-07 00:26] falls asleep\r\n[1518-11-09 00:26] falls asleep\r\n[1518-09-17 00:17] falls asleep\r\n[1518-04-06 00:17] falls asleep\r\n[1518-04-11 00:18] falls asleep\r\n[1518-10-19 00:00] Guard #2887 begins shift\r\n[1518-02-22 00:48] wakes up\r\n[1518-03-31 00:57] wakes up\r\n[1518-07-08 00:38] wakes up\r\n[1518-03-13 00:50] wakes up\r\n[1518-03-01 00:58] wakes up\r\n[1518-11-05 00:27] falls asleep\r\n[1518-03-12 00:19] wakes up\r\n[1518-07-09 00:31] falls asleep\r\n[1518-05-05 00:40] wakes up\r\n[1518-08-05 00:48] wakes up\r\n[1518-08-12 00:23] wakes up\r\n[1518-03-01 00:47] wakes up\r\n[1518-05-14 00:56] falls asleep\r\n[1518-05-18 23:46] Guard #2251 begins shift\r\n[1518-07-13 00:34] wakes up\r\n[1518-05-11 00:54] wakes up\r\n[1518-05-12 00:53] falls asleep\r\n[1518-10-10 00:49] falls asleep\r\n[1518-10-19 23:57] Guard #103 begins shift\r\n[1518-03-22 00:01] Guard #1447 begins shift\r\n[1518-08-30 00:23] falls asleep\r\n[1518-04-25 00:25] wakes up\r\n[1518-07-09 00:42] wakes up\r\n[1518-06-07 00:02] Guard #677 begins shift\r\n[1518-09-06 00:10] falls asleep\r\n[1518-10-31 00:56] wakes up\r\n[1518-09-19 00:55] wakes up\r\n[1518-08-19 00:48] falls asleep\r\n[1518-03-04 00:13] falls asleep\r\n[1518-05-17 23:59] Guard #2593 begins shift\r\n[1518-06-21 23:59] Guard #2423 begins shift\r\n[1518-08-18 00:57] wakes up\r\n[1518-03-28 00:01] falls asleep\r\n[1518-06-25 23:59] Guard #1171 begins shift\r\n[1518-04-23 00:23] wakes up\r\n[1518-10-12 00:56] wakes up\r\n[1518-10-25 00:18] falls asleep\r\n[1518-07-05 00:53] wakes up\r\n[1518-11-02 00:57] wakes up\r\n[1518-10-11 00:36] falls asleep\r\n[1518-09-30 23:57] Guard #1097 begins shift\r\n[1518-09-25 00:29] wakes up\r\n[1518-07-18 00:40] wakes up\r\n[1518-03-04 00:35] falls asleep\r\n[1518-08-14 00:12] falls asleep\r\n[1518-08-29 00:25] falls asleep\r\n[1518-05-01 00:33] falls asleep\r\n[1518-09-22 23:58] Guard #727 begins shift\r\n[1518-11-18 00:04] Guard #1709 begins shift\r\n[1518-11-01 00:54] wakes up\r\n[1518-04-11 00:50] wakes up\r\n[1518-11-03 00:49] wakes up\r\n[1518-09-03 00:39] falls asleep\r\n[1518-04-11 00:01] Guard #2593 begins shift\r\n[1518-09-27 00:29] wakes up\r\n[1518-03-24 23:59] Guard #2593 begins shift\r\n[1518-06-28 00:28] wakes up\r\n[1518-11-14 00:59] wakes up\r\n[1518-04-04 00:48] wakes up\r\n[1518-04-01 00:35] falls asleep\r\n[1518-06-08 00:15] wakes up\r\n[1518-05-24 00:28] falls asleep\r\n[1518-06-03 00:25] falls asleep\r\n[1518-09-15 00:58] wakes up\r\n[1518-02-26 00:58] wakes up\r\n[1518-06-07 23:57] Guard #2423 begins shift\r\n[1518-06-05 00:08] falls asleep\r\n[1518-06-22 00:58] wakes up\r\n[1518-09-23 00:53] wakes up\r\n[1518-02-28 00:53] wakes up\r\n[1518-03-03 23:56] Guard #1447 begins shift\r\n[1518-05-01 00:01] Guard #2251 begins shift\r\n[1518-08-24 23:57] Guard #1709 begins shift\r\n[1518-11-05 23:47] Guard #277 begins shift\r\n[1518-05-11 00:44] wakes up\r\n[1518-04-13 23:50] Guard #727 begins shift\r\n[1518-05-20 00:44] wakes up\r\n[1518-05-07 00:55] wakes up\r\n[1518-03-17 00:24] falls asleep\r\n[1518-06-18 00:08] wakes up\r\n[1518-03-12 00:23] falls asleep\r\n[1518-11-09 00:34] wakes up\r\n[1518-11-03 00:00] Guard #433 begins shift\r\n[1518-10-03 00:10] falls asleep\r\n[1518-05-29 00:04] Guard #2251 begins shift\r\n[1518-07-02 00:19] wakes up\r\n[1518-03-04 00:18] wakes up\r\n[1518-07-01 00:37] falls asleep\r\n[1518-10-09 00:40] wakes up\r\n[1518-11-10 00:02] falls asleep\r\n[1518-05-14 00:53] wakes up\r\n[1518-02-25 00:31] wakes up\r\n[1518-04-24 00:50] wakes up\r\n[1518-09-04 00:40] wakes up\r\n[1518-03-28 00:55] wakes up\r\n[1518-10-30 00:26] wakes up\r\n[1518-10-06 00:54] wakes up\r\n[1518-10-25 00:50] wakes up\r\n[1518-03-22 00:23] falls asleep\r\n[1518-10-11 00:55] wakes up\r\n[1518-04-30 00:04] Guard #2251 begins shift\r\n[1518-06-29 00:44] falls asleep\r\n[1518-03-04 00:27] wakes up\r\n[1518-02-27 00:57] falls asleep\r\n[1518-03-06 00:54] wakes up\r\n[1518-08-28 00:40] falls asleep\r\n[1518-04-19 00:22] wakes up\r\n[1518-06-05 00:30] wakes up\r\n[1518-03-19 00:36] wakes up\r\n[1518-11-09 23:46] Guard #2689 begins shift\r\n[1518-09-12 00:45] falls asleep\r\n[1518-03-24 00:00] Guard #2423 begins shift\r\n[1518-10-28 00:58] wakes up\r\n[1518-11-19 00:19] falls asleep\r\n[1518-10-22 00:31] wakes up\r\n[1518-04-20 00:58] wakes up\r\n[1518-04-21 00:57] wakes up\r\n[1518-10-14 00:55] wakes up\r\n[1518-09-26 00:49] wakes up\r\n[1518-05-17 00:50] falls asleep\r\n[1518-07-03 00:28] falls asleep\r\n[1518-11-22 00:03] Guard #1871 begins shift\r\n[1518-04-04 00:29] falls asleep\r\n[1518-08-22 00:58] wakes up\r\n[1518-10-06 00:22] wakes up\r\n[1518-07-28 00:55] falls asleep\r\n[1518-08-12 00:55] falls asleep\r\n[1518-08-13 23:59] Guard #433 begins shift\r\n[1518-09-22 00:00] Guard #433 begins shift\r\n[1518-08-15 00:13] wakes up\r\n[1518-10-05 00:03] Guard #2689 begins shift\r\n[1518-06-05 00:38] falls asleep\r\n[1518-10-06 00:03] Guard #1097 begins shift\r\n[1518-03-23 00:11] falls asleep\r\n[1518-06-25 00:34] wakes up\r\n[1518-11-21 00:27] wakes up\r\n[1518-06-22 00:39] wakes up\r\n[1518-08-22 00:41] wakes up\r\n[1518-09-12 23:56] Guard #2689 begins shift\r\n[1518-11-05 00:43] falls asleep\r\n[1518-08-06 00:04] Guard #727 begins shift\r\n[1518-05-04 00:02] Guard #1447 begins shift\r\n[1518-10-21 00:57] wakes up\r\n[1518-04-21 00:11] falls asleep\r\n[1518-10-04 00:31] falls asleep\r\n[1518-08-05 00:10] falls asleep\r\n[1518-11-06 00:48] wakes up\r\n[1518-05-25 00:03] Guard #1171 begins shift\r\n[1518-02-24 00:44] falls asleep\r\n[1518-05-06 00:05] falls asleep\r\n[1518-05-09 00:26] wakes up\r\n[1518-07-15 00:58] wakes up\r\n[1518-11-07 00:57] falls asleep\r\n[1518-10-31 00:46] wakes up\r\n[1518-07-01 00:57] falls asleep\r\n[1518-04-15 00:17] falls asleep\r\n[1518-08-31 00:41] falls asleep\r\n[1518-09-26 00:43] wakes up\r\n[1518-08-09 00:47] wakes up\r\n[1518-10-28 00:31] falls asleep\r\n[1518-05-24 00:59] wakes up\r\n[1518-02-15 23:57] Guard #433 begins shift\r\n[1518-05-31 00:02] Guard #727 begins shift\r\n[1518-05-25 00:56] wakes up\r\n[1518-05-14 00:01] Guard #1709 begins shift\r\n[1518-11-22 00:30] wakes up\r\n[1518-07-28 00:27] wakes up\r\n[1518-04-20 00:41] falls asleep\r\n[1518-04-10 00:48] wakes up\r\n[1518-08-19 00:08] falls asleep\r\n[1518-03-29 00:45] wakes up\r\n[1518-07-29 00:03] Guard #2423 begins shift\r\n[1518-10-26 00:54] wakes up\r\n[1518-07-21 00:48] falls asleep\r\n[1518-07-05 00:30] falls asleep\r\n[1518-04-15 00:26] wakes up\r\n[1518-07-06 00:47] wakes up\r\n[1518-11-07 00:58] wakes up\r\n[1518-10-09 00:25] falls asleep\r\n[1518-10-30 00:37] wakes up\r\n[1518-09-18 00:03] Guard #2593 begins shift\r\n[1518-10-28 23:57] Guard #1171 begins shift\r\n[1518-02-24 00:41] wakes up\r\n[1518-05-02 00:29] wakes up\r\n[1518-10-17 00:40] wakes up\r\n[1518-06-18 00:57] wakes up\r\n[1518-06-14 00:59] wakes up\r\n[1518-07-07 00:21] falls asleep\r\n[1518-07-02 00:14] falls asleep\r\n[1518-03-22 00:51] falls asleep\r\n[1518-11-12 00:23] wakes up\r\n[1518-08-21 00:33] falls asleep\r\n[1518-07-11 00:52] wakes up\r\n[1518-03-15 00:01] falls asleep\r\n[1518-09-07 23:46] Guard #727 begins shift\r\n[1518-07-04 00:20] falls asleep\r\n[1518-09-13 00:35] wakes up\r\n[1518-11-04 23:58] Guard #239 begins shift\r\n[1518-07-03 00:00] Guard #2689 begins shift\r\n[1518-05-11 00:15] falls asleep\r\n[1518-08-12 00:04] Guard #1097 begins shift\r\n[1518-11-13 00:55] wakes up\r\n[1518-03-24 00:42] wakes up\r\n[1518-07-22 00:16] falls asleep\r\n[1518-07-27 00:46] wakes up\r\n[1518-02-16 00:55] wakes up\r\n[1518-09-23 00:08] falls asleep\r\n[1518-11-12 00:00] Guard #277 begins shift\r\n[1518-08-03 00:04] falls asleep\r\n[1518-04-21 00:01] Guard #2689 begins shift\r\n[1518-09-03 00:03] Guard #2423 begins shift\r\n[1518-06-26 23:58] Guard #2689 begins shift\r\n[1518-03-29 00:00] Guard #2251 begins shift\r\n[1518-05-19 23:59] Guard #1171 begins shift\r\n[1518-05-16 23:58] Guard #2251 begins shift\r\n[1518-08-03 00:52] falls asleep\r\n[1518-03-03 00:01] Guard #2887 begins shift\r\n[1518-07-26 00:54] wakes up\r\n[1518-09-03 23:46] Guard #1097 begins shift\r\n[1518-04-26 00:03] Guard #821 begins shift\r\n[1518-04-08 00:39] wakes up\r\n[1518-05-30 00:00] Guard #1871 begins shift\r\n[1518-11-12 00:18] falls asleep\r\n[1518-06-04 00:10] falls asleep\r\n[1518-07-12 23:53] Guard #2689 begins shift\r\n[1518-07-30 00:00] Guard #239 begins shift\r\n[1518-08-20 00:00] Guard #1871 begins shift\r\n[1518-06-13 23:58] Guard #1171 begins shift\r\n[1518-08-25 00:25] wakes up\r\n[1518-06-23 00:00] Guard #433 begins shift\r\n[1518-09-21 00:43] falls asleep\r\n[1518-10-16 00:23] falls asleep\r\n[1518-10-10 00:38] falls asleep\r\n[1518-08-30 23:57] Guard #2887 begins shift\r\n[1518-04-05 23:58] Guard #2887 begins shift\r\n[1518-05-02 00:36] falls asleep\r\n[1518-10-03 00:15] wakes up\r\n[1518-09-02 00:58] wakes up\r\n[1518-03-19 00:04] Guard #103 begins shift\r\n[1518-04-19 00:39] falls asleep\r\n[1518-10-01 23:58] Guard #1709 begins shift\r\n[1518-03-11 00:13] wakes up\r\n[1518-10-06 00:49] falls asleep\r\n[1518-11-21 00:39] falls asleep\r\n[1518-07-14 00:16] falls asleep\r\n[1518-09-30 00:31] falls asleep\r\n[1518-02-24 00:03] Guard #1097 begins shift\r\n[1518-08-19 00:00] Guard #1051 begins shift\r\n[1518-05-07 00:42] falls asleep\r\n[1518-04-22 23:58] Guard #2593 begins shift\r\n[1518-04-05 00:00] Guard #739 begins shift\r\n[1518-11-08 00:23] falls asleep\r\n[1518-03-12 00:01] Guard #109 begins shift\r\n[1518-04-28 00:37] falls asleep\r\n[1518-07-22 23:58] Guard #281 begins shift\r\n[1518-07-27 00:43] falls asleep\r\n[1518-06-16 00:59] wakes up\r\n[1518-07-24 00:49] falls asleep\r\n[1518-03-11 00:10] falls asleep\r\n[1518-07-06 00:51] falls asleep\r\n[1518-11-08 00:54] wakes up\r\n[1518-11-21 00:24] falls asleep\r\n[1518-07-21 00:53] wakes up\r\n[1518-05-11 00:48] falls asleep\r\n[1518-06-21 00:55] wakes up\r\n[1518-09-24 00:03] Guard #1249 begins shift\r\n[1518-07-14 00:00] Guard #1871 begins shift\r\n[1518-05-29 00:10] falls asleep\r\n[1518-03-14 00:40] falls asleep\r\n[1518-03-09 00:01] Guard #2423 begins shift\r\n[1518-07-26 00:48] falls asleep\r\n[1518-04-03 00:44] falls asleep\r\n[1518-05-14 00:38] falls asleep\r\n[1518-05-28 00:48] falls asleep\r\n[1518-06-02 00:54] wakes up\r\n[1518-05-02 00:57] wakes up\r\n[1518-06-19 23:58] Guard #727 begins shift\r\n[1518-02-27 00:45] falls asleep\r\n[1518-10-24 00:04] Guard #1447 begins shift\r\n[1518-07-12 00:47] falls asleep\r\n[1518-09-08 00:23] wakes up\r\n[1518-10-26 00:57] falls asleep\r\n[1518-08-06 00:58] wakes up\r\n[1518-05-12 00:57] wakes up\r\n[1518-03-07 00:53] wakes up\r\n[1518-09-04 00:55] wakes up\r\n[1518-07-28 00:12] falls asleep\r\n[1518-03-16 00:52] wakes up\r\n[1518-09-03 00:31] wakes up\r\n[1518-09-24 00:58] wakes up\r\n[1518-09-15 00:56] falls asleep\r\n[1518-09-25 00:08] falls asleep\r\n[1518-08-07 00:36] falls asleep\r\n[1518-04-27 00:02] Guard #739 begins shift\r\n[1518-08-18 00:30] wakes up\r\n[1518-08-31 00:44] wakes up\r\n[1518-09-06 00:52] wakes up\r\n[1518-06-06 00:38] wakes up\r\n[1518-02-20 00:02] Guard #239 begins shift\r\n[1518-03-07 23:57] Guard #2593 begins shift\r\n[1518-08-02 00:11] falls asleep\r\n[1518-08-16 00:47] falls asleep\r\n[1518-09-04 00:47] falls asleep\r\n[1518-09-16 00:56] wakes up\r\n[1518-02-18 00:02] Guard #277 begins shift\r\n[1518-04-25 00:55] falls asleep\r\n[1518-11-19 00:31] wakes up\r\n[1518-02-25 00:18] falls asleep\r\n[1518-06-16 00:07] falls asleep\r\n[1518-03-18 00:00] Guard #2423 begins shift\r\n[1518-10-24 00:41] falls asleep\r\n[1518-02-26 00:57] falls asleep\r\n[1518-08-05 00:02] Guard #2593 begins shift\r\n[1518-05-27 00:00] Guard #1871 begins shift\r\n[1518-04-18 00:47] falls asleep\r\n[1518-04-14 00:00] falls asleep\r\n[1518-03-09 00:16] falls asleep\r\n[1518-04-01 00:38] wakes up\r\n[1518-05-16 00:59] wakes up\r\n[1518-11-01 00:02] falls asleep\r\n[1518-04-04 00:18] wakes up\r\n[1518-05-31 23:57] Guard #281 begins shift\r\n[1518-02-17 00:42] wakes up\r\n[1518-09-19 00:50] wakes up\r\n[1518-05-01 00:50] wakes up\r\n[1518-09-05 00:28] falls asleep\r\n[1518-11-22 00:11] falls asleep\r\n[1518-04-28 00:00] Guard #433 begins shift\r\n[1518-06-12 00:58] wakes up\r\n[1518-10-01 00:39] wakes up\r\n[1518-04-29 00:01] Guard #2251 begins shift\r\n[1518-09-11 00:28] falls asleep\r\n[1518-05-28 00:57] wakes up\r\n[1518-09-01 00:57] wakes up\r\n[1518-06-13 00:47] wakes up\r\n[1518-05-16 00:50] falls asleep\r\n[1518-11-16 00:03] Guard #677 begins shift\r\n[1518-06-08 00:55] wakes up\r\n[1518-09-08 00:16] falls asleep\r\n[1518-06-24 00:40] falls asleep\r\n[1518-09-21 00:27] wakes up\r\n[1518-07-06 00:57] wakes up\r\n[1518-11-10 23:50] Guard #739 begins shift\r\n[1518-03-13 00:49] falls asleep\r\n[1518-10-15 00:04] Guard #1249 begins shift\r\n[1518-07-10 23:57] Guard #239 begins shift\r\n[1518-02-19 00:01] Guard #109 begins shift\r\n[1518-06-16 23:58] Guard #2251 begins shift\r\n[1518-10-27 23:56] Guard #1051 begins shift\r\n[1518-09-13 00:59] wakes up\r\n[1518-09-14 00:17] falls asleep\r\n[1518-04-30 00:56] wakes up\r\n[1518-08-16 00:21] falls asleep\r\n[1518-05-10 00:55] wakes up\r\n[1518-08-10 00:44] wakes up\r\n[1518-09-08 00:00] falls asleep\r\n[1518-04-10 00:22] wakes up\r\n[1518-09-14 00:40] wakes up\r\n[1518-09-26 00:58] wakes up\r\n[1518-10-31 00:00] Guard #103 begins shift\r\n[1518-07-07 00:00] Guard #2689 begins shift\r\n[1518-06-26 00:24] wakes up\r\n[1518-11-01 00:36] falls asleep\r\n[1518-09-16 00:43] falls asleep\r\n[1518-08-18 00:33] falls asleep\r\n[1518-09-09 00:45] falls asleep\r\n[1518-03-30 00:49] wakes up\r\n[1518-09-05 00:13] wakes up\r\n[1518-07-20 00:51] wakes up\r\n[1518-06-29 00:04] Guard #433 begins shift\r\n[1518-08-27 00:12] wakes up\r\n[1518-06-14 00:43] falls asleep\r\n[1518-07-06 00:39] falls asleep\r\n[1518-10-10 00:44] wakes up\r\n[1518-10-13 00:00] Guard #1871 begins shift\r\n[1518-06-06 00:16] falls asleep\r\n[1518-05-12 00:32] falls asleep\r\n[1518-07-16 23:50] Guard #2423 begins shift\r\n[1518-04-07 00:52] wakes up\r\n[1518-09-26 00:55] falls asleep\r\n[1518-09-29 00:57] falls asleep\r\n[1518-07-20 00:15] falls asleep\r\n[1518-06-26 00:44] wakes up\r\n[1518-04-06 23:59] Guard #1097 begins shift\r\n[1518-03-30 00:02] Guard #739 begins shift\r\n[1518-08-02 00:30] wakes up\r\n[1518-05-07 00:01] Guard #2887 begins shift\r\n[1518-03-21 00:01] Guard #281 begins shift\r\n[1518-07-08 23:56] Guard #1871 begins shift\r\n[1518-07-05 00:40] wakes up\r\n[1518-08-02 23:51] Guard #109 begins shift\r\n[1518-08-08 00:01] Guard #677 begins shift\r\n[1518-03-27 23:49] Guard #1447 begins shift\r\n[1518-09-01 00:17] falls asleep\r\n[1518-03-04 23:59] Guard #239 begins shift\r\n[1518-06-29 00:45] wakes up\r\n[1518-05-14 00:52] falls asleep\r\n[1518-06-02 00:04] Guard #1871 begins shift\r\n[1518-09-23 00:42] falls asleep\r\n[1518-08-17 00:28] falls asleep\r\n[1518-08-23 00:50] wakes up\r\n[1518-09-10 23:51] Guard #1871 begins shift\r\n[1518-04-04 00:05] falls asleep\r\n[1518-10-04 00:00] Guard #2593 begins shift\r\n[1518-10-12 00:42] falls asleep\r\n[1518-04-25 00:44] falls asleep\r\n[1518-06-23 00:42] wakes up\r\n[1518-03-14 00:53] falls asleep\r\n[1518-08-19 00:15] wakes up\r\n[1518-08-12 00:18] falls asleep\r\n[1518-10-24 00:47] wakes up\r\n[1518-10-27 00:11] falls asleep\r\n[1518-10-10 23:57] Guard #739 begins shift\r\n[1518-09-03 00:28] falls asleep\r\n[1518-05-05 23:51] Guard #1171 begins shift\r\n[1518-03-20 00:37] falls asleep\r\n[1518-07-31 00:13] falls asleep\r\n[1518-07-25 00:47] falls asleep\r\n[1518-05-26 00:47] wakes up\r\n[1518-08-22 00:19] falls asleep\r\n[1518-10-22 00:44] wakes up\r\n[1518-04-27 00:58] wakes up\r\n[1518-08-09 00:32] falls asleep\r\n[1518-06-08 00:28] falls asleep\r\n[1518-10-15 00:43] falls asleep\r\n[1518-09-08 00:12] wakes up\r\n[1518-05-09 00:02] falls asleep\r\n[1518-03-24 00:30] falls asleep\r\n[1518-03-26 23:48] Guard #2689 begins shift\r\n[1518-02-22 00:47] falls asleep\r\n[1518-08-04 00:58] wakes up\r\n[1518-07-31 00:36] wakes up\r\n[1518-08-12 00:51] wakes up\r\n[1518-04-19 00:11] wakes up\r\n[1518-06-30 00:00] Guard #2593 begins shift\r\n[1518-07-25 00:53] wakes up\r\n[1518-03-01 00:54] falls asleep\r\n[1518-05-21 00:57] wakes up\r\n[1518-05-10 00:02] Guard #239 begins shift\r\n[1518-04-21 00:19] wakes up\r\n[1518-02-20 00:13] falls asleep\r\n[1518-06-15 00:36] falls asleep\r\n[1518-05-13 00:35] falls asleep\r\n[1518-02-25 23:56] Guard #2251 begins shift\r\n[1518-10-06 00:25] falls asleep\r\n[1518-03-17 00:56] wakes up\r\n[1518-10-05 00:41] falls asleep\r\n[1518-07-19 00:53] falls asleep\r\n[1518-05-04 23:57] Guard #2593 begins shift\r\n[1518-03-26 00:57] wakes up\r\n[1518-10-23 00:50] falls asleep\r\n[1518-03-01 00:45] falls asleep\r\n[1518-07-30 00:57] wakes up\r\n[1518-05-29 00:48] wakes up\r\n[1518-08-26 23:58] Guard #727 begins shift\r\n[1518-07-21 00:24] wakes up\r\n[1518-09-15 00:16] wakes up\r\n[1518-10-25 00:03] Guard #2251 begins shift\r\n[1518-03-11 00:40] wakes up\r\n[1518-06-29 00:25] falls asleep\r\n[1518-03-13 00:36] wakes up\r\n[1518-05-18 00:50] wakes up\r\n[1518-02-22 00:18] falls asleep\r\n[1518-09-28 00:02] Guard #1171 begins shift\r\n[1518-09-20 23:59] Guard #2423 begins shift\r\n[1518-03-27 00:44] wakes up\r\n[1518-11-13 00:51] falls asleep\r\n[1518-03-07 00:38] falls asleep\r\n[1518-04-14 00:26] wakes up\r\n[1518-03-13 23:59] Guard #1097 begins shift\r\n[1518-03-26 00:36] wakes up\r\n[1518-08-16 00:26] wakes up\r\n[1518-06-05 00:00] Guard #1447 begins shift\r\n[1518-11-15 00:02] Guard #1097 begins shift\r\n[1518-05-14 00:25] falls asleep\r\n[1518-09-13 00:29] falls asleep\r\n[1518-06-29 00:33] wakes up\r\n[1518-10-24 00:29] wakes up\r\n[1518-05-23 00:02] Guard #1871 begins shift\r\n[1518-11-12 00:52] wakes up\r\n[1518-10-20 23:59] Guard #727 begins shift\r\n[1518-06-14 23:58] Guard #2251 begins shift\r\n[1518-11-04 00:20] falls asleep\r\n[1518-05-04 00:56] wakes up\r\n[1518-06-14 00:40] wakes up\r\n[1518-10-20 00:17] falls asleep\r\n[1518-03-04 00:54] wakes up\r\n[1518-06-09 00:59] wakes up\r\n[1518-09-22 00:51] wakes up\r\n[1518-11-12 00:26] falls asleep\r\n[1518-09-11 00:45] wakes up\r\n[1518-05-08 00:46] wakes up\r\n[1518-05-14 00:32] wakes up\r\n[1518-06-07 00:10] falls asleep\r\n[1518-09-28 00:20] falls asleep\r\n[1518-05-02 00:00] Guard #1171 begins shift\r\n[1518-08-10 00:49] falls asleep\r\n[1518-11-14 00:24] wakes up\r\n[1518-09-20 00:57] wakes up\r\n[1518-02-24 00:27] wakes up\r\n[1518-07-08 00:03] Guard #677 begins shift\r\n[1518-08-10 00:53] wakes up\r\n[1518-03-22 00:54] wakes up\r\n[1518-02-21 00:21] falls asleep\r\n[1518-03-15 00:58] wakes up\r\n[1518-05-25 00:55] falls asleep\r\n[1518-10-22 00:43] falls asleep\r\n[1518-08-04 00:33] falls asleep\r\n[1518-07-22 00:00] Guard #1249 begins shift\r\n[1518-08-01 00:53] wakes up\r\n[1518-04-06 00:55] wakes up\r\n[1518-05-20 00:58] wakes up\r\n[1518-10-20 00:55] wakes up\r\n[1518-04-13 00:03] Guard #1447 begins shift\r\n[1518-09-29 23:59] Guard #2593 begins shift\r\n[1518-06-25 00:30] falls asleep\r\n[1518-08-22 00:46] falls asleep\r\n[1518-05-14 00:59] wakes up\r\n[1518-09-27 00:00] falls asleep\r\n[1518-10-21 00:34] falls asleep\r\n[1518-07-09 23:48] Guard #1249 begins shift\r\n[1518-06-13 00:00] Guard #739 begins shift\r\n[1518-11-08 00:04] Guard #739 begins shift\r\n[1518-11-09 00:02] Guard #103 begins shift\r\n[1518-08-24 00:23] falls asleep\r\n[1518-10-08 00:45] falls asleep\r\n[1518-07-21 00:00] Guard #1097 begins shift\r\n[1518-06-19 00:23] falls asleep\r\n[1518-05-15 00:43] wakes up\r\n[1518-04-25 00:20] falls asleep\r\n[1518-08-02 00:01] Guard #239 begins shift\r\n[1518-07-03 00:25] wakes up\r\n[1518-10-18 00:01] Guard #281 begins shift\r\n[1518-06-24 00:06] falls asleep\r\n[1518-07-26 00:00] Guard #677 begins shift\r\n[1518-10-06 00:38] wakes up\r\n[1518-10-10 00:57] wakes up\r\n[1518-04-01 00:44] falls asleep\r\n[1518-05-17 00:57] wakes up\r\n[1518-04-27 00:48] wakes up\r\n[1518-05-20 23:56] Guard #727 begins shift\r\n[1518-11-04 00:15] wakes up\r\n[1518-09-24 00:52] falls asleep\r\n[1518-11-02 00:55] falls asleep\r\n[1518-04-08 00:17] falls asleep\r\n[1518-06-25 00:00] Guard #677 begins shift\r\n[1518-11-17 00:02] Guard #739 begins shift\r\n[1518-04-25 00:52] wakes up\r\n[1518-09-10 00:52] wakes up\r\n[1518-03-13 00:07] falls asleep\r\n[1518-09-23 00:18] falls asleep\r\n[1518-06-10 00:25] falls asleep\r\n[1518-10-07 00:55] wakes up\r\n[1518-10-27 00:16] wakes up\r\n[1518-11-10 00:10] wakes up\r\n[1518-10-31 23:50] Guard #109 begins shift\r\n[1518-09-19 00:54] falls asleep\r\n[1518-06-18 00:16] falls asleep\r\n[1518-08-25 00:23] falls asleep\r\n[1518-10-15 00:52] wakes up\r\n[1518-07-20 00:02] Guard #1097 begins shift\r\n[1518-02-16 00:45] wakes up\r\n[1518-10-30 00:00] Guard #2887 begins shift\r\n[1518-04-01 23:56] Guard #1447 begins shift\r\n[1518-05-15 00:12] falls asleep\r\n[1518-08-17 00:34] wakes up\r\n[1518-05-19 00:01] falls asleep\r\n[1518-10-16 00:02] Guard #727 begins shift\r\n[1518-08-29 00:49] wakes up\r\n[1518-04-12 00:23] falls asleep\r\n[1518-10-17 00:02] Guard #2689 begins shift\r\n[1518-03-28 00:38] falls asleep\r\n[1518-06-18 00:01] falls asleep\r\n[1518-09-23 00:33] wakes up\r\n[1518-07-08 00:35] falls asleep\r\n[1518-09-01 00:01] Guard #727 begins shift\r\n[1518-02-22 00:38] wakes up\r\n[1518-08-14 00:55] wakes up\r\n[1518-11-07 00:04] Guard #2251 begins shift\r\n[1518-07-17 00:05] falls asleep\r\n[1518-02-20 00:48] wakes up\r\n[1518-09-14 00:00] Guard #103 begins shift\r\n[1518-11-10 00:58] wakes up\r\n[1518-08-15 00:01] Guard #433 begins shift\r\n[1518-05-16 00:17] falls asleep\r\n[1518-07-28 00:00] Guard #1249 begins shift\r\n[1518-04-03 23:52] Guard #1871 begins shift\r\n[1518-10-22 00:02] Guard #2887 begins shift\r\n[1518-09-27 00:19] wakes up\r\n[1518-04-05 00:35] falls asleep\r\n[1518-11-03 00:39] falls asleep\r\n[1518-03-16 00:55] falls asleep\r\n[1518-09-21 00:16] falls asleep\r\n[1518-08-22 00:04] Guard #2887 begins shift\r\n[1518-07-18 23:59] Guard #1709 begins shift\r\n[1518-07-10 00:43] wakes up\r\n[1518-03-02 00:38] falls asleep\r\n[1518-05-27 00:52] falls asleep\r\n[1518-02-25 00:00] Guard #109 begins shift\r\n[1518-11-03 23:56] Guard #1447 begins shift\r\n[1518-06-17 00:17] falls asleep\r\n[1518-05-28 00:37] wakes up\r\n[1518-06-26 00:40] falls asleep\r\n[1518-06-09 00:53] falls asleep\r\n[1518-07-03 00:22] falls asleep\r\n[1518-04-13 00:45] wakes up\r\n[1518-04-09 00:36] falls asleep\r\n[1518-09-17 00:00] Guard #677 begins shift\r\n[1518-09-26 00:47] falls asleep\r\n[1518-02-27 23:59] Guard #2887 begins shift\r\n[1518-10-22 00:54] falls asleep\r\n[1518-09-23 00:56] falls asleep\r\n[1518-10-19 00:46] wakes up\r\n[1518-03-25 00:40] falls asleep\r\n[1518-06-11 00:02] Guard #1051 begins shift\r\n[1518-05-16 00:22] wakes up\r\n[1518-08-15 00:47] falls asleep\r\n[1518-05-18 00:15] falls asleep\r\n[1518-09-11 00:18] wakes up\r\n[1518-04-30 00:43] falls asleep\r\n[1518-08-28 00:01] Guard #433 begins shift\r\n[1518-06-19 00:00] Guard #103 begins shift\r\n[1518-10-08 23:57] Guard #103 begins shift\r\n[1518-04-19 00:19] falls asleep\r\n[1518-11-23 00:12] falls asleep\r\n[1518-08-15 00:55] wakes up\r\n[1518-10-22 00:25] falls asleep\r\n[1518-03-26 00:00] Guard #1871 begins shift\r\n[1518-07-30 00:40] falls asleep\r\n[1518-02-23 00:04] Guard #2251 begins shift\r\n[1518-03-02 00:54] wakes up\r\n[1518-02-21 00:45] wakes up\r\n[1518-08-24 00:03] Guard #277 begins shift\r\n[1518-06-26 00:15] falls asleep\r\n[1518-02-17 00:00] Guard #677 begins shift\r\n[1518-04-12 00:50] wakes up\r\n[1518-03-05 23:56] Guard #2251 begins shift\r\n[1518-03-09 00:57] wakes up\r\n[1518-07-23 23:56] Guard #727 begins shift\r\n[1518-06-08 00:10] falls asleep\r\n[1518-09-02 00:56] falls asleep\r\n[1518-04-23 00:19] falls asleep\r\n[1518-08-10 00:01] Guard #2423 begins shift\r\n[1518-08-12 00:40] falls asleep\r\n[1518-09-18 00:20] falls asleep\r\n[1518-05-20 00:31] falls asleep\r\n[1518-02-20 23:56] Guard #1097 begins shift\r\n[1518-04-19 00:48] wakes up\r\n[1518-05-25 23:57] Guard #109 begins shift\r\n[1518-03-08 00:51] wakes up\r\n[1518-04-01 00:01] Guard #433 begins shift\r\n[1518-08-08 00:19] wakes up\r\n[1518-09-13 00:39] falls asleep\r\n[1518-03-14 00:31] wakes up\r\n[1518-02-28 00:25] falls asleep\r\n[1518-03-10 00:54] wakes up\r\n[1518-08-26 00:07] falls asleep\r\n[1518-06-24 00:37] wakes up\r\n[1518-04-23 23:46] Guard #109 begins shift\r\n[1518-08-16 00:58] wakes up\r\n[1518-06-02 00:25] falls asleep\r\n[1518-03-05 00:34] falls asleep\r\n[1518-02-22 00:58] wakes up\r\n[1518-09-17 00:32] falls asleep\r\n[1518-09-15 00:05] falls asleep\r\n[1518-07-29 00:55] wakes up\r\n[1518-03-12 00:27] wakes up\r\n[1518-10-15 00:17] falls asleep\r\n[1518-06-10 00:39] wakes up\r\n[1518-06-27 23:47] Guard #277 begins shift\r\n[1518-06-13 00:35] falls asleep\r\n[1518-05-12 00:04] Guard #2593 begins shift\r\n[1518-05-20 00:52] falls asleep\r\n[1518-11-15 00:22] wakes up\r\n[1518-05-13 00:04] Guard #677 begins shift\r\n[1518-10-07 00:54] falls asleep\r\n[1518-07-17 00:54] wakes up\r\n[1518-06-28 00:02] falls asleep\r\n[1518-11-19 23:58] Guard #821 begins shift\r\n[1518-08-11 00:18] falls asleep\r\n[1518-04-17 23:58] Guard #2593 begins shift\r\n[1518-10-15 00:58] wakes up\r\n[1518-11-02 00:47] falls asleep\r\n[1518-11-18 00:47] wakes up\r\n[1518-06-10 00:04] Guard #103 begins shift\r\n[1518-07-01 00:58] wakes up\r\n[1518-06-07 00:47] wakes up\r\n[1518-10-29 00:33] wakes up\r\n[1518-10-30 00:13] falls asleep\r\n[1518-03-26 00:16] falls asleep\r\n[1518-09-29 00:03] Guard #103 begins shift\r\n[1518-08-02 00:51] wakes up\r\n[1518-11-14 00:55] falls asleep\r\n[1518-03-19 00:30] falls asleep\r\n[1518-06-08 00:50] falls asleep\r\n[1518-11-02 00:52] wakes up\r\n[1518-08-27 00:39] wakes up\r\n[1518-05-27 00:53] wakes up\r\n[1518-09-19 00:02] Guard #2593 begins shift\r\n[1518-10-07 23:56] Guard #1051 begins shift\r\n[1518-06-11 00:06] falls asleep\r\n[1518-04-14 00:54] wakes up\r\n[1518-08-13 00:34] falls asleep\r\n[1518-03-07 00:00] Guard #103 begins shift\r\n[1518-11-05 00:50] wakes up\r\n[1518-11-06 00:02] falls asleep\r\n[1518-07-01 00:02] Guard #109 begins shift\r\n[1518-05-22 00:00] Guard #2689 begins shift\r\n[1518-08-16 23:57] Guard #1249 begins shift\r\n[1518-09-17 00:37] wakes up\r\n[1518-03-31 00:00] Guard #1871 begins shift\r\n[1518-02-21 23:57] Guard #677 begins shift\r\n[1518-04-15 00:03] Guard #1447 begins shift\r\n[1518-04-22 00:00] Guard #3121 begins shift\r\n[1518-09-12 00:03] Guard #433 begins shift\r\n[1518-06-19 00:43] wakes up\r\n[1518-07-18 00:00] Guard #1709 begins shift\r\n[1518-11-10 00:26] falls asleep\r\n[1518-04-01 00:30] wakes up\r\n[1518-06-17 00:57] wakes up\r\n[1518-06-23 00:40] falls asleep\r\n[1518-03-11 00:00] Guard #739 begins shift\r\n[1518-04-16 00:47] wakes up\r\n[1518-11-17 00:24] falls asleep\r\n[1518-06-17 23:54] Guard #277 begins shift\r\n[1518-05-10 23:59] Guard #1447 begins shift\r\n[1518-07-22 00:52] wakes up\r\n[1518-04-10 00:03] falls asleep\r\n[1518-08-26 00:50] wakes up\r\n[1518-05-26 00:20] wakes up\r\n[1518-05-14 23:57] Guard #2423 begins shift\r\n[1518-05-22 00:40] wakes up\r\n[1518-05-10 00:26] falls asleep\r\n[1518-08-24 00:56] wakes up\r\n[1518-06-04 00:58] wakes up\r\n[1518-07-16 00:58] wakes up\r\n[1518-05-12 00:48] wakes up\r\n[1518-03-22 00:46] wakes up\r\n[1518-03-20 00:00] Guard #739 begins shift\r\n[1518-04-17 00:24] falls asleep\r\n[1518-02-18 00:06] falls asleep\r\n[1518-09-11 00:05] falls asleep\r\n[1518-08-17 00:46] falls asleep\r\n[1518-10-27 00:04] Guard #1051 begins shift\r\n[1518-03-18 00:41] wakes up\r\n[1518-09-17 00:19] wakes up\r\n[1518-08-17 00:53] wakes up\r\n[1518-06-14 00:17] falls asleep\r\n[1518-11-10 00:51] falls asleep\r\n[1518-03-29 00:44] falls asleep\r\n[1518-08-08 00:16] falls asleep\r\n[1518-05-05 00:55] wakes up\r\n[1518-11-15 00:38] wakes up\r\n[1518-03-07 00:12] falls asleep\r\n[1518-03-31 00:48] falls asleep\r\n[1518-06-24 00:55] wakes up\r\n[1518-10-11 23:57] Guard #1447 begins shift\r\n[1518-07-27 00:20] falls asleep\r\n[1518-09-30 00:48] falls asleep\r\n[1518-04-08 00:03] Guard #109 begins shift\r\n[1518-11-16 00:51] wakes up\r\n[1518-05-23 00:15] falls asleep\r\n[1518-08-16 00:57] falls asleep\r\n[1518-11-16 00:20] falls asleep\r\n[1518-06-24 00:03] Guard #109 begins shift\r\n[1518-02-16 00:50] falls asleep\r\n[1518-07-27 00:35] wakes up\r\n[1518-08-16 00:04] Guard #1097 begins shift\r\n[1518-10-26 00:59] wakes up\r\n[1518-09-20 00:03] Guard #109 begins shift\r\n[1518-10-07 00:01] Guard #2251 begins shift\r\n[1518-03-05 00:51] wakes up\r\n[1518-08-30 00:45] wakes up\r\n[1518-08-11 00:49] wakes up\r\n[1518-10-03 00:58] wakes up\r\n[1518-06-12 00:46] falls asleep\r\n[1518-03-30 00:44] falls asleep\r\n[1518-09-01 23:59] Guard #109 begins shift\r\n[1518-03-11 00:31] falls asleep\r\n[1518-04-12 00:03] Guard #677 begins shift\r\n[1518-08-13 00:59] wakes up\r\n[1518-11-23 00:30] wakes up\r\n[1518-02-19 00:21] falls asleep\r\n[1518-08-07 00:53] wakes up\r\n[1518-04-13 00:54] wakes up\r\n[1518-07-04 00:02] Guard #109 begins shift\r\n[1518-04-28 00:57] wakes up\r\n[1518-04-27 00:52] falls asleep\r\n[1518-04-03 00:48] wakes up";
        public static List<Day4Entry> entries = new List<Day4Entry>();
        public static Dictionary<int, Day4Guard> guards = new Dictionary<int, Day4Guard>();
        public static List<Day4day> days = new List<Day4day>();
        public static string parse(string problem)
        {


            /* //
                [1518-11-01 00:00] Guard #10 begins shift
                [1518-11-01 00:05] falls asleep
                [1518-11-01 00:25] wakes up
                [1518-11-01 00:30] falls asleep
                [1518-11-01 00:55] wakes up
                [1518-11-01 23:58] Guard #99 begins shift
                [1518-11-02 00:40] falls asleep
                [1518-11-02 00:50] wakes up
                [1518-11-03 00:05] Guard #10 begins shift
                [1518-11-03 00:24] falls asleep
                [1518-11-03 00:29] wakes up
                [1518-11-04 00:02] Guard #99 begins shift
                [1518-11-04 00:36] falls asleep
                [1518-11-04 00:46] wakes up
                [1518-11-05 00:03] Guard #99 begins shift
                [1518-11-05 00:45] falls asleep
                [1518-11-05 00:55] wakes up
                */

            entries = new List<Day4Entry>();
            var problems = problem.Split("\r\n");
            foreach (string unparsedEntry in problems)
            {
                Day4Entry entry = new Day4Entry(unparsedEntry);
                entries.Add(entry);
            }

            entries.Sort();
            string returnvalue = "";
            foreach (var entry in entries)
            {
                returnvalue += entry.ToString() + "<br/>";
            }

            //now that we're sorted, we can do several things
            //loop through the entries and get days
            //simultaneously get a list of guards

             guards = new Dictionary<int, Day4Guard>();
             days = new List<Day4day>();
            int guardID;

            var currentGuard = new Day4Guard(-1);
            Day4day currentDay = new Day4day(new DateTime(1900,1,1), ref currentGuard);
            


            //iterate through all sorted entries, creating guards as necessary, adding minutes as necessary.
            
            
            foreach (var entry in entries)
            {
                //[1518-11-01 23:58] Guard #99 begins shift
                //[1518 - 11 - 02 00:40] falls asleep
                //[1518 - 11 - 02 00:50] wakes up
                if (entry.action.Substring(0, 5) == "Guard")
                { 
                    //new shift, create day, create guard.
                    //assign guard to day


                    var IDPieces = entry.action.Split(" ");
                    guardID = int.Parse(IDPieces[1].Substring(1));
                    guards.TryGetValue(guardID, out currentGuard);
                    if (currentGuard == null)
                    {
                        currentGuard = new Day4Guard(guardID);
                        guards.TryAdd(currentGuard.ID, currentGuard);
                    }

                    currentDay = new Day4day(entry.timestamp, ref currentGuard);
                    days.Add(currentDay);

                }
                else if (entry.action.Substring(0, 5) == "falls")
                {

                    //First the guard is set to being asleep
                    //second the timestamp is set
                    currentDay.guard.fallAsleep(entry.timestamp);
                }
                else if (entry.action.Substring(0, 5) == "wakes")
                {
                    //find out the time they fell asleep
                    //find out the time they woke up
                    //add time asleep to day.
                    currentGuard.awaken(entry.timestamp);
                    var startsleep = currentGuard.timeFellAsleep;

                    currentGuard.totalTimeAsleep += Convert.ToInt32((entry.timestamp - startsleep).TotalMinutes);
                    for (int i = startsleep.Minute; i < entry.timestamp.Minute; i++)
                    {
                        currentDay.minutesAwake[i] = false; 
                    }

                }
            }



            return returnvalue;
        }

        public static string solvePart1()
        {

            Day4Guard maxGuard = new Day4Guard(-1);
            foreach(Day4Guard guard in guards.Values)
            {
                if (guard.totalTimeAsleep > maxGuard.totalTimeAsleep)
                {
                    maxGuard = guard;
                }
            }
            var minutes = new int[60];
            for (int i = 0; i < 60; i++)
            {
                minutes[i] = 0;
            }
            foreach (Day4day day in days)
            {
                
                if (day.guard.ID == maxGuard.ID) //filter only on the correct guards
                {
                    string dbgout = "[";
                    for (int i = 0; i < 60; i++)
                    {
                        if (day.minutesAwake[i] == false)
                        {
                            minutes[i] += 1;
                        }
                        dbgout += minutes[i] + ",";
                    }
                    dbgout += "]";
                }
                
            }

            var maxminute = 0;
            var maxID = 0;
            for (int i = 0; i < 60; i++)
            {
                if (minutes[i] > maxminute)
                {
                    maxminute = minutes[i];
                    maxID = i;
                }
            }

                var outstring = "Guard ID[" + maxGuard.ID + "] was asleep like so: <br/>[";
            foreach (int i in minutes)
            {
                outstring += "," + i;
            }
            outstring += "]<br/> optimal minute = ["+maxID+", " + maxminute + " times]<br/>";
            outstring += "Checksum = <b>[" + (maxID * maxGuard.ID) + "]</b>";
            return outstring;
        }
        public static string solvePart2()
        {
            //there's going to be a [60XguardID] array.
            //find which guard has the highest individual count of minutes asleep.


            return "";
        }

    }
    public class Day4Entry : IComparable<Day4Entry>
    {
        public DateTime timestamp;

        public string action;
        public Day4Entry(string str)
        {
            try
            {
                var timestampfragment = str.Split("] ")[0].Substring(1);
                timestamp = DateTime.Parse(timestampfragment);
                action = str.Split("] ")[1];

            }
            catch (Exception e)
            {
                Console.WriteLine("[ERROR][Day4] - Failed to parse:" + str);
            }
        }

        int IComparable<Day4Entry>.CompareTo(Day4Entry other)
        {
            if (other == null) return 1;
            if (this.timestamp == other.timestamp)
            {
                return 0;
            }
            else if (this.timestamp < other.timestamp)
            {
                return -1;
            }
            else if (this.timestamp > other.timestamp)
            {
                return 1;
            }
            return 0;
        }

        public override string ToString()
        {
            return "[" + this.timestamp.ToString() + "] " + this.action;

        }
        //date & time
        //ID as text
        //action = start/sleep/wake
    }

    public class Day4Guard
    {
        public int ID;
        public DateTime timeFellAsleep;
        public bool awake;
        public int totalTimeAsleep;
        public int[] timeasleepperminute;
        public Day4Guard(int newID)
        {
            this.ID = newID;
            awake = true;
            totalTimeAsleep = 0;
            timeasleepperminute = new int[60];
            for (int i = 0; i<60; i++)
            {
                i++;
            }
        }

        public void fallAsleep(DateTime timestamp)
        {
            awake = false;
            timeFellAsleep = timestamp;
        }
        public void awaken(DateTime timestamp)
        {
            awake = true;
        }
        public void incrementMinute (int minuteId)
        {
            
        }
        //ID
        //total minutes asleep
    }

    public class Day4day
    {
        public DateTime timestamp;
        public bool[] minutesAwake = new bool[60]; //true = awake,   false= asleep
        public Day4Guard guard;
        public Day4day (DateTime timestamp, ref Day4Guard guard)
        {
            this.timestamp = timestamp;
            this.guard = guard;

            for (int i = 0; i < 60; i++)
            {
                minutesAwake[i]= true;
            }
        }
        //1 date = key
        //60 booleans
        //1 guard assigned
 
    }
}
