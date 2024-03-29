# The isBadVersion API is already defined for you.
# @param version, an integer
# @return an integer
# def isBadVersion(version):

class Solution:
    def firstBadVersion(self, n):
        """
        :type n: int
        :rtype: int
        """

        left,right = 1,n;

        while(left <= right):
            mid = int(left + (right - left)/2);

            if(isBadVersion(mid)):
                right = mid -1;
            else:
                left = mid + 1;

        return left;


    
