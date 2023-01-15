using Application.Authentication.Common;
using Mapster;

namespace Application.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        // config.NewConfig<AuthenticationResult, AuthenticationResponse>()
        //     .Map(dest => dest.token, src => src.token)
        //     .Map(dest => dest.refreshToken, src => src.refreshToken)
        //     .Map(dest => dest.expiresIn, src => src.expiresIn);
    }
}
