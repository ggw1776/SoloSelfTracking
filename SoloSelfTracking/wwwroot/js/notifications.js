var warningnotification = new Audio('../audio/545495__ienba__notification.wav')
var calmingnotification = new Audio('../audio/511437__theojt__relaxing-short-music.mp3')
var startnotification = new Audio('../audio/495004__evretro__alert-video-game-sound.wav')
var stopnotification = new Audio('../audio/535840__evretro__8-bit-mini-win-sound-effect.wav')
window.notificationUtilities = {
    warning: async function (text) {
        toastr.warning(text);
        warningnotification.play();
    },
    calm: async function () {
        calmingnotification.play();
    },
    startTimer: async function (text) {
        toastr.info(text);
        startnotification.play();
    },
    stopTimer: async function (text) {
        toastr.info(text);
        stopnotification.play();
    },
};