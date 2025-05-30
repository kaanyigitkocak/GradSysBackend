using Application.Features.Notifications.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Notifications.Queries.GetById;

public class GetByIdNotificationQuery : IRequest<GetByIdNotificationResponse>
{
    public Guid Id { get; set; }

    public class GetByIdNotificationQueryHandler : IRequestHandler<GetByIdNotificationQuery, GetByIdNotificationResponse>
    {
        private readonly IMapper _mapper;
        private readonly INotificationRepository _notificationRepository;
        private readonly NotificationBusinessRules _notificationBusinessRules;

        public GetByIdNotificationQueryHandler(IMapper mapper, INotificationRepository notificationRepository, NotificationBusinessRules notificationBusinessRules)
        {
            _mapper = mapper;
            _notificationRepository = notificationRepository;
            _notificationBusinessRules = notificationBusinessRules;
        }

        public async Task<GetByIdNotificationResponse> Handle(GetByIdNotificationQuery request, CancellationToken cancellationToken)
        {
            Notification? notification = await _notificationRepository.GetAsync(predicate: n => n.Id == request.Id, cancellationToken: cancellationToken);
            await _notificationBusinessRules.NotificationShouldExistWhenSelected(notification);

            GetByIdNotificationResponse response = _mapper.Map<GetByIdNotificationResponse>(notification);
            return response;
        }
    }
}