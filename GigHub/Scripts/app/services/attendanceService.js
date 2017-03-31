var AttendanceService = function () {

    var addAttendance = function (gigId, done, fail) {
        $.post("/api/attendances", { gigId: gigId })
            .done(done)
            .fail(fail);
    };

    var deleteAttendance = function (gigId, done, fail) {
        $.ajax({
            url: "/api/attendances/" + gigId,
            method: "DELETE"
        })
            .done(done)
            .fail(fail);
    };

    return {
        addAttendance: addAttendance,
        deleteAttendance: deleteAttendance
    };
}();
