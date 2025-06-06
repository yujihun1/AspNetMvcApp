﻿using Note.Model;

namespace Note.IDAL
{
    public interface INoticeDal
    {
        /// <summary>
        /// 1. 공지사항 리스트 출력
        /// </summary>
        /// <returns></returns>
        List<Notice> GetNoticeList();

        /// <summary>
        /// 2. 공지사항 상세 출력
        /// </summary>
        /// <param name="noticeNo"></param>
        /// <returns></returns>
        Notice GetNotice(int noticeNo);

        /// <summary>
        /// 3. 공지사항 등록
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        bool PostNotice(Notice notice);

            /// <summary>
            /// 4. 공지사항 수정
            /// </summary>
            /// <param name="notice"></param>
            /// <returns></returns>
        bool UpdateNotice(Notice notice);

        /// <summary>
        /// 5. 공지사항 삭제
        /// </summary>
        /// <param name="noticeNo"></param>
        /// <returns></returns>
        bool DeleteNotice(int noticeNo);

    }
}
