using System;
using System.Collections.Generic;
using Raccoon.Ninja.Extensions.Common.Internationalization;
using Xunit;

namespace Raccoon.Ninja.Extensions.Common.Tests
{
    public class DateTimeExtensionsTest
    {
        [Fact]
        public void AdjustToMinuteEnd_Success()
        {
            var originalDateTime = new DateTime(2021, 12, 31, 0, 0, 0, 0);
            var expectedDataTime = new DateTime(2021, 12, 31, 0, 0, 59, 999);
            var dateTimeAdjusted = originalDateTime.AdjustToMinuteEnd();

            Assert.Equal(expectedDataTime, dateTimeAdjusted);
        }

        [Fact]
        public void AdjustToMinuteStart_Success()
        {
            var originalDateTime = new DateTime(2021, 12, 31, 0, 0, 59, 999);
            var expectedDataTime = new DateTime(2021, 12, 31, 0, 0, 0, 0);
            var dateTimeAdjusted = originalDateTime.AdjustToMinuteStart();

            Assert.Equal(expectedDataTime, dateTimeAdjusted);
        }

        [Fact]
        public void AdjustDate_Success()
        {
            var originalDateTime = new DateTime(2020, 10, 1, 0, 0, 0, 0);
            var expectedDataTime = new DateTime(2021, 12, 31, 0, 0, 0, 0);
            var dateTimeAdjusted = originalDateTime.AdjustDate(2021, 12, 31);

            Assert.Equal(expectedDataTime, dateTimeAdjusted);
        }

        [Fact]
        public void AdjustTime_Success()
        {
            var originalDateTime = new DateTime(2021, 12, 31, 0, 3, 59, 999);
            var expectedDataTime = new DateTime(2021, 12, 31, 12, 59, 18, 10);
            var dateTimeAdjusted = originalDateTime.AdjustTime(12, 59, 18, 10);

            Assert.Equal(expectedDataTime, dateTimeAdjusted);
        }
        
        [Fact]
        public void AdjustTime_Error_Success()
        {

            var exception = Assert.Throws<ArgumentException>(() => DateTime.Now.AdjustTime(minute: 99));

            Assert.Equal(ErrorMessages.InvalidDateManipulation, exception.Message);
        }

        [Fact]
        public void AdjustDate_Error_Success()
        {

            var exception = Assert.Throws<ArgumentException>(() => DateTime.Now.AdjustDate(day: 31, month: 2));

            Assert.Equal(ErrorMessages.InvalidDateManipulation, exception.Message);
        }
        
        [Fact]
        public void IsToday_Success_Today()
        {
            new List<DateTime> {DateTime.UtcNow, DateTime.Now}.ForEach(dt =>
            {
                Assert.True(dt.IsToday());         
            });
        }

        [Fact]
        public void IsToday_Success_NotToday()
        {
            new List<DateTime> {DateTime.UtcNow, DateTime.Now}.ForEach(dt =>
            {
                var date = dt.AddDays(-1);
                Assert.False(date.IsToday());         
            });
        }

        [Fact]
        public void IsTodaySameHour_Success_TodaySameHour()
        {
            new List<DateTime> {DateTime.UtcNow, DateTime.Now}.ForEach(dt =>
            {
                Assert.True(dt.IsTodaySameHour());                
            });
        }

        [Fact]
        public void IsTodaySameHour_Success_NotToday()
        {
            new List<DateTime> {DateTime.UtcNow, DateTime.Now}.ForEach(dt =>
            {
                var date = dt.AddDays(-1);
                Assert.False(date.IsTodaySameHour());                
            });
        }

        [Fact]
        public void IsTodaySameHour_Success_TodayNotSameHour()
        {
            new List<DateTime> {DateTime.UtcNow, DateTime.Now}.ForEach(dt =>
            {
                var date = dt.AddHours(-1);
                Assert.False(date.IsTodaySameHour());                
            });
        }

        [Fact]
        public void IsSameDate_True_Success()
        {
            var today = DateTime.Now;
            var thisMorning = new DateTime(today.Year, today.Month, today.Day, 9, 0, 0, 0);
            var tonight =  new DateTime(today.Year, today.Month, today.Day, 21, 0, 0, 0);
            
            Assert.True(thisMorning.IsSameDate(tonight));
        }
        
        [Fact]
        public void IsSameDate_False_Success()
        {
            var today = DateTime.Now;
            var thisMorning = new DateTime(today.Year, today.Month, today.Day, 9, 0, 0, 0);
            var nextMorning =  thisMorning.AddDays(1);
            
            Assert.False(thisMorning.IsSameDate(nextMorning));
        }

        [Fact]
        public void IsMidnight_True_Local_Success()
        {
            var today = DateTime.Now;
            var midnight = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0, 0);
            Assert.True(midnight.IsMidnight());
        }
        
        [Fact]
        public void IsMidnight_True_Utc_ImplicitOffset_Success()
        {
            var today = DateTime.Now;
            var midnight = new DateTime(today.Year, today.Month, today.Day, 3, 0, 0, 0, DateTimeKind.Utc);
            Assert.True(midnight.IsMidnight());
        }
        
        [Fact]
        public void IsMidnight_True_Utc_ExplicitOffset_Success()
        {
            var today = DateTime.Now;
            var midnight = new DateTime(today.Year, today.Month, today.Day, 3, 0, 0, 0, DateTimeKind.Utc);
            Assert.True(midnight.IsMidnight(180));
        }
    }
}