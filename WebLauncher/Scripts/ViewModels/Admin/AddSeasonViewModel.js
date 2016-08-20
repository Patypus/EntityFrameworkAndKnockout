var addSeasonViewModel = function (data) {
    var self = this;

    self.availableYears = ko.observableArray(data.years);
};