var UsersController = function (followingService) {

    var button;

    var init = function () {
        $('.js-toggle-follow').click(toggleFollow);
    };

    toggleFollow = function (e) {

        button = $(e.target);
        var userId = button.attr("data-followee-id");

        if (button.hasClass("fa-heart-o")) {
            followingService.addFollowing(userId, done, fail);
        }
        else {
            followingService.deleteFollowing(userId, done, fail);
        }

    };

    var done = function () {
        button
            .toggleClass("fa-heart-o")
            .toggleClass("fa-heart");
    };

    var fail = function () {
        alert("Something went wrong!/delete");
    };

    return {
        init: init
    };

}(FollowingService);