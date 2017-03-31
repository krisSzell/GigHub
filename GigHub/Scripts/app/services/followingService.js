var FollowingService = function () {

    var addFollowing = function (userId, done, fail) {
        $.post("/api/followings", { followeeId: userId })
            .done(done)
            .fail(fail);
    };

    var deleteFollowing = function (userId, done, fail) {
        $.ajax({
            url: "/api/followings/" + userId,
            method: "DELETE"
        })
            .done(done)
            .fail(fail);
    };

    return {
        addFollowing: addFollowing,
        deleteFollowing: deleteFollowing
    };
}();