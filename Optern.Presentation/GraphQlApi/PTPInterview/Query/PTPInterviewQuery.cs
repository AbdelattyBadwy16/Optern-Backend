﻿
using Optern.Application.DTOs.Question;

namespace Optern.Presentation.GraphQlApi.PTPInterview.Query
{
    [ExtendObjectType("Query")]
    public class PTPInterviewQuery
    {
        [GraphQLDescription("Get Upcoming PTP Interviews")]

        public async Task<Response<IEnumerable<UpcomingPTPInterviewDTO>>> GetAllUpcomingPTPInterviews([Service] IPTPInterviewService PTPInterviewService, string userId) 
            => await PTPInterviewService.GetAllUpcomingPTPInterviews(userId);

        [GraphQLDescription("Get PTP Interview TimeSlots")]
        public async Task<Response<List<PTPInterviewTimeSlotDTO>>> GetPTPInterviewTimeSlotsAsync([Service] IPTPInterviewService PTPInterviewService,InterviewCategory category, InterviewQuestionType questionType, string scheduledDate)
            => await PTPInterviewService.GetPTPInterviewTimeSlotsAsync(category,questionType,scheduledDate);

        [GraphQLDescription("Get all questions for a specific user in an interview.")]
        public async Task<Response<List<PTPQuestionDTO>>> GetUserPTPInterviewQuestions(int interviewId,string userId,[Service] IPTPInterviewService _interviewService)
        
           =>  await _interviewService.GetUserPTPInterviewQuestionsAsync(interviewId, userId);

        [GraphQLDescription("Get Past Interviews")]

        public async Task<Response<IEnumerable<PastInterviews>>> PastInterviews([Service] IPTPInterviewService PTPInterviewService, string userId)
          => await PTPInterviewService.PastInterviews(userId);
        [GraphQLDescription("Get Cached Interview Data")]
        public Response<InterviewCachedData> LoadInterviewCachedData([Service] IPTPInterviewService _pTPInterviewService, int interviewId) =>
             _pTPInterviewService.LoadInterviewCachedData(interviewId);


    }
}
