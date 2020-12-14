﻿using Bickers.Twaddle.Generators;

namespace Bickers.Twaddle.Configuration
{
    public interface ITwaddleConfiguration
    {
        ICredentialGenerator CredentialConfig { get; }

        IDateGenerator DateConfig { get; }

        IPhoneGenerator PhoneConfig { get; }

        IColourGenerator ColourConfig { get; }

        IWordGenerator WordConfig { get; }

        INameGenerator NameGenerator { get; }
    }
}