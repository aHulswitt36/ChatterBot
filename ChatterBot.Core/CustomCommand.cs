﻿namespace ChatterBot.Core
{
    public class CustomCommand : BaseBindable
    {
        private string _commandWord = "!";
        private Access _access = Access.Everyone;
        private string _response;
        private int _cooldownTime;
        private int _userCooldownTime;
        private bool _enabled = true;

        public string CommandWord
        {
            get => _commandWord;
            set => SetProperty(ref _commandWord, value);
        }

        public Access Access
        {
            get => _access;
            set => SetProperty(ref _access, value);
        }

        public string Response
        {
            get => _response;
            set => SetProperty(ref _response, value);
        }

        public int CooldownTime
        {
            get => _cooldownTime;
            set => SetProperty(ref _cooldownTime, value);
        }

        public int UserCooldownTime
        {
            get => _userCooldownTime;
            set => SetProperty(ref _userCooldownTime, value);
        }

        public bool Enabled
        {
            get => _enabled;
            set => SetProperty(ref _enabled, value);
        }
    }
}