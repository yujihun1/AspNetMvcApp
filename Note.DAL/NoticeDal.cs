﻿using Microsoft.Extensions.Configuration;
using Note.DAL.DataContext;
using Note.IDAL;
using Note.Model;

namespace Note.DAL
{
    public class NoticeDal : INoticeDal
    {
        private readonly IConfiguration _configuration;

        public NoticeDal(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// 1. 공지사항 리스트 출력
        /// </summary>
        /// <returns></returns>
        public List<Notice> GetNoticeList()
        {
            using (var db = new NoteDbContext(_configuration))
            {
                return db.Notices
                         .OrderByDescending(n =>n.NoticeNo)
                         .ToList();
            }
        }

        /// <summary>
        /// 2. 공지사항 상세 출력
        /// </summary>
        /// <param name="noticeNo"></param>
        /// <returns></returns>
        public Notice GetNotice(int noticeNo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 3. 공지사항 등록
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns> 
        public bool PostNotice(Notice notice)
        {
            throw new NotImplementedException();
        }
            
        /// <summary>
        /// 4. 공지사항 수정
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>

        public bool UpdateNotice(Notice notice)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 5. 공지사항 삭제
        /// </summary>
        /// <param name="noticeNo"></param>
        /// <returns></returns>
        public bool DeleteNotice(int noticeNo)
        {
            throw new NotImplementedException();
        }

    }
}
