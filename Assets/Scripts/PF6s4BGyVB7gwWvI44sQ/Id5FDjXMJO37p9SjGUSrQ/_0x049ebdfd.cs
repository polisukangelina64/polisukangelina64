using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x049ebdfd : MonoBehaviour
{
    private bool _0xfbe909cd(string _0xf5df302b)
    {
        try
        {
            using (var _0xb505a8de = new AndroidJavaClass(_0x893dd4c5._0x4756ee13(new byte[30] { 90, 86, 84, 23, 76, 87, 80, 77, 64, 10, 93, 23, 73, 85, 88, 64, 92, 75, 23, 108, 87, 80, 77, 64, 105, 85, 88, 64, 92, 75 }, 57)))
            using (var _0x4494831f = _0xb505a8de.GetStatic<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[15] { 67, 85, 82, 82, 69, 78, 84, 97, 67, 84, 73, 86, 73, 84, 89 }, 32)))
            using (var _0x03b839b5 = new AndroidJavaClass(_0x893dd4c5._0x4756ee13(new byte[15] { 34, 45, 39, 49, 44, 42, 39, 109, 45, 38, 55, 109, 22, 49, 42 }, 67)))
            using (var _0x3fdc43a4 = _0x03b839b5.CallStatic<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[5] { 97, 112, 99, 98, 116 }, 17), _0xf5df302b))
            using (var _0xfa7c6a10 = new AndroidJavaObject(_0x893dd4c5._0x4756ee13(new byte[22] { 65, 78, 68, 82, 79, 73, 68, 14, 67, 79, 78, 84, 69, 78, 84, 14, 105, 78, 84, 69, 78, 84 }, 32), _0x893dd4c5._0x4756ee13(new byte[26] { 47, 32, 42, 60, 33, 39, 42, 96, 39, 32, 58, 43, 32, 58, 96, 47, 45, 58, 39, 33, 32, 96, 24, 7, 11, 25 }, 78), _0x3fdc43a4))
            {
                WLog(_0x893dd4c5._0x4756ee13(new byte[26] { 196, 239, 245, 232, 234, 226, 203, 238, 236, 226, 167, 232, 247, 226, 233, 167, 226, 255, 243, 226, 245, 233, 230, 235, 189, 167 }, 135) + _0xf5df302b);
                _0xfa7c6a10.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[11] { 14, 11, 11, 44, 14, 27, 10, 8, 0, 29, 22 }, 111), _0x893dd4c5._0x4756ee13(new byte[33] { 88, 87, 93, 75, 86, 80, 93, 23, 80, 87, 77, 92, 87, 77, 23, 90, 88, 77, 92, 94, 86, 75, 64, 23, 123, 107, 118, 110, 106, 120, 123, 117, 124 }, 57));
                _0xfa7c6a10.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[8] { 226, 231, 231, 197, 239, 226, 228, 240 }, 131), 0x10000000);
                _0x4494831f.Call(_0x893dd4c5._0x4756ee13(new byte[13] { 149, 146, 135, 148, 146, 167, 133, 146, 143, 144, 143, 146, 159 }, 230), _0xfa7c6a10);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x893dd4c5._0x4756ee13(new byte[28] { 63, 20, 14, 19, 17, 25, 48, 21, 23, 25, 92, 25, 4, 8, 25, 14, 18, 29, 16, 92, 26, 29, 21, 16, 25, 24, 70, 92 }, 124) + e.Message);
            Application.OpenURL(_0xf5df302b);
            return true;
        }
    }

    private bool _0x4d1e0303 = false;
    private async Task<string> _0x0c0b04cd(int _0x97d4c0b2 = 5, int _0x3b7316d1 = 500)
    {
        try
        {
            List<EntityData> _0xa02a552e = new List<EntityData>();
            int _0xc3264bcc = 0;
            do
            {
                _0xa02a552e = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x893dd4c5._0x4756ee13(new byte[8] { 94, 66, 79, 87, 75, 92, 103, 74 }, 46), _0xf9b182fa, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xf9b182fa }), new QueryOptions())).ToList();
                await Task.Delay(_0x3b7316d1);
            }
            while (_0xa02a552e.Count == 0 && _0xc3264bcc++ < _0x97d4c0b2);
            {
#if B_LOGS
                {
                    Debug.Log(_0x893dd4c5._0x4756ee13(new byte[33] { 27, 20, 37, 51, 52, 29, 96, 19, 33, 54, 37, 36, 96, 12, 41, 46, 43, 96, 17, 53, 37, 50, 57, 96, 50, 37, 51, 53, 44, 52, 51, 122, 96 }, 64) + JsonConvert.SerializeObject(_0xa02a552e, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x893dd4c5._0x4756ee13(new byte[39] { 212, 219, 234, 252, 251, 210, 175, 220, 238, 249, 234, 235, 175, 195, 230, 225, 228, 175, 222, 250, 234, 253, 246, 175, 253, 234, 252, 250, 227, 251, 252, 175, 236, 224, 250, 225, 251, 181, 175 }, 143) + _0xa02a552e.Count);
                }
#endif
            }

            var _0x9e1e15f3 = _0xa02a552e.SelectMany(_0x62c93a74 => _0x62c93a74.Data).FirstOrDefault(_0x88b9bb2e => _0x88b9bb2e.Key == _0xf9b182fa)?.Value.GetAs<string>() ?? string.Empty;
            _0x9e1e15f3 = Decrypt(_0x9e1e15f3, _0xf9b182fa);
            {
#if B_LOGS
                {
                    Debug.Log(_0x893dd4c5._0x4756ee13(new byte[24] { 113, 126, 79, 89, 94, 119, 10, 102, 69, 75, 78, 10, 89, 75, 92, 79, 78, 10, 70, 67, 68, 65, 16, 10 }, 42) + _0x9e1e15f3);
                }
#endif
            }

            return _0x9e1e15f3;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x893dd4c5._0x4756ee13(new byte[39] { 65, 78, 127, 105, 110, 71, 58, 93, 127, 110, 58, 117, 104, 58, 106, 123, 104, 105, 127, 58, 105, 123, 108, 127, 126, 58, 118, 115, 116, 113, 58, 124, 123, 115, 118, 127, 126, 32, 58 }, 26) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private int _0x21cfa60a = 0;
    private int _0xec6c768e = -1;
    internal bool IsAboutBlank(string _0x413cf674)
    {
        if (string.IsNullOrEmpty(_0x413cf674))
            return false;
        return _0x413cf674.StartsWith(_0x893dd4c5._0x4756ee13(new byte[11] { 210, 209, 220, 198, 199, 137, 209, 223, 210, 221, 216 }, 179), StringComparison.OrdinalIgnoreCase);
    }

    private string _0xb114febf;
    internal string _0x322aed22(string _0x04b07a78)
    {
        int _0x459e68ea = _0x04b07a78.IndexOf(_0x893dd4c5._0x4756ee13(new byte[3] { 10, 7, 94 }, 99), StringComparison.OrdinalIgnoreCase);
        if (_0x459e68ea < 0)
            return null;
        string _0x31b23fc4 = _0x04b07a78.Substring(_0x459e68ea + 3);
        int _0xbe81e658 = _0x31b23fc4.IndexOf('&');
        return _0xbe81e658 >= 0 ? _0x31b23fc4.Substring(0, _0xbe81e658) : _0x31b23fc4;
    }

    private void _0x15a34f16(UniWebView _0x187b720c)
    {
        if (_0x20ed2072)
            return;
        _0x20ed2072 = true;
        _0x187b720c.AddUrlScheme(_0x893dd4c5._0x4756ee13(new byte[2] { 186, 169 }, 206));
        _0x187b720c.AddUrlScheme(_0x893dd4c5._0x4756ee13(new byte[6] { 123, 124, 102, 119, 124, 102 }, 18));
        _0x187b720c.AddUrlScheme(_0x893dd4c5._0x4756ee13(new byte[6] { 133, 137, 154, 131, 141, 156 }, 232));
        _0x187b720c.OnMessageReceived += (_0x1256e783, _0x2d1dab49) =>
        {
            if (TryOpenExternalLikeChrome(_0x2d1dab49.RawMessage))
            {
                _0xa4f9701d(false);
                return;
            }
        };
        _0x187b720c.RegisterShouldHandleRequest(_0xa6e4b339 =>
        {
            string _0x165543db = _0xa6e4b339 != null ? _0xa6e4b339.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x165543db))
                return true;
            WLog(_0x893dd4c5._0x4756ee13(new byte[21] { 223, 228, 227, 249, 224, 232, 196, 237, 226, 232, 224, 233, 222, 233, 253, 249, 233, 255, 248, 182, 172 }, 140) + _0x165543db);
            if (TryOpenExternalLikeChrome(_0x165543db))
            {
                _0xa4f9701d(false);
                return false;
            }

            if (_0xa6e4b339 != null && _0xa6e4b339.IsMainFrame && IsGoogleAuthFlowUrl(_0x165543db) && !_0x81cb971e)
            {
                WLog(_0x893dd4c5._0x4756ee13(new byte[62] { 24, 52, 60, 59, 117, 2, 48, 55, 3, 60, 48, 34, 117, 49, 48, 33, 48, 54, 33, 48, 49, 117, 18, 58, 58, 50, 57, 48, 117, 52, 32, 33, 61, 117, 0, 7, 25, 117, 120, 107, 117, 39, 48, 57, 58, 52, 49, 117, 34, 60, 33, 61, 117, 18, 58, 58, 50, 57, 48, 117, 0, 20 }, 85));
                _0x81cb971e = true;
                _0xa4f9701d(true);
                _0x5f57ded1.SetUserAgent(_0xe23a5340());
                _0x5f57ded1.Load(_0x165543db);
                return false;
            }

            return true;
        });
        _0x187b720c.OnLoadingErrorReceived += (_0x1256e783, _0x2526ff33, _0x2d1dab49, _0x60af8e6f) =>
        {
            WLog(_0x893dd4c5._0x4756ee13(new byte[25] { 60, 16, 24, 31, 81, 38, 20, 19, 39, 24, 20, 6, 81, 52, 3, 3, 30, 3, 75, 81, 18, 30, 21, 20, 76 }, 113) + _0x2526ff33 + _0x893dd4c5._0x4756ee13(new byte[9] { 44, 97, 105, 127, 127, 109, 107, 105, 49 }, 12) + _0x2d1dab49);
            string _0xd7bbd6b7 = GetFailingUrl(_0x60af8e6f);
            if (string.IsNullOrEmpty(_0xd7bbd6b7) || IsAboutBlank(_0xd7bbd6b7))
                return;
            _ = _0xe280eb0a(_0x893dd4c5._0x4756ee13(new byte[8] { 159, 158, 183, 141, 154, 154, 135, 154 }, 232));
            WLog(_0x893dd4c5._0x4756ee13(new byte[45] { 211, 255, 247, 240, 190, 201, 251, 252, 200, 247, 251, 233, 190, 248, 255, 247, 242, 247, 240, 249, 190, 203, 204, 210, 190, 179, 160, 190, 241, 238, 251, 240, 190, 251, 230, 234, 251, 236, 240, 255, 242, 242, 231, 164, 190 }, 158) + _0xd7bbd6b7);
            StopCurrentFailedLoad(_0x1256e783);
            _0x3a3bfb7c(_0xd7bbd6b7);
        };
        _0x187b720c.OnPageStarted += (_0x1256e783, _0x95f0bc89) =>
        {
            _0x21cfa60a = 0;
            if (_0x57aff127 && IsAboutBlank(_0x95f0bc89))
            {
                WLog(_0x893dd4c5._0x4756ee13(new byte[27] { 255, 221, 202, 216, 206, 221, 194, 143, 206, 205, 192, 218, 219, 149, 205, 195, 206, 193, 196, 143, 220, 219, 206, 221, 219, 202, 203 }, 175));
                return;
            }

            WLog(_0x893dd4c5._0x4756ee13(new byte[29] { 183, 155, 147, 148, 218, 173, 159, 152, 172, 147, 159, 141, 218, 181, 148, 170, 155, 157, 159, 169, 142, 155, 136, 142, 159, 158, 192, 218, 209 }, 250) + (Time.realtimeSinceStartup - _0x357e8593).ToString(_0x893dd4c5._0x4756ee13(new byte[5] { 170, 180, 170, 170, 170 }, 154)) + _0x893dd4c5._0x4756ee13(new byte[2] { 129, 210 }, 242) + _0x95f0bc89);
            if (TryOpenExternalLikeChrome(_0x95f0bc89))
            {
                StopCurrentFailedLoad(_0x1256e783);
                return;
            }

            if (ContainsIgnoreCase(_0x95f0bc89, _0x893dd4c5._0x4756ee13(new byte[8] { 145, 156, 156, 148, 219, 148, 133, 133 }, 245)) || ContainsIgnoreCase(_0x95f0bc89, _0x893dd4c5._0x4756ee13(new byte[15] { 164, 181, 173, 250, 163, 189, 176, 179, 177, 160, 250, 182, 184, 187, 179 }, 212)) || _0x95f0bc89.StartsWith(_0x893dd4c5._0x4756ee13(new byte[25] { 191, 163, 163, 167, 164, 237, 248, 248, 181, 167, 176, 187, 184, 181, 182, 187, 177, 182, 161, 249, 187, 190, 161, 178, 248 }, 215), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x1256e783);
                OpenUrlExternally(_0x95f0bc89);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x95f0bc89))
            {
                _0xa4f9701d(true);
                WLog(_0x893dd4c5._0x4756ee13(new byte[41] { 255, 215, 215, 223, 212, 221, 152, 217, 205, 204, 208, 152, 222, 212, 215, 207, 152, 220, 221, 204, 221, 219, 204, 221, 220, 152, 149, 134, 152, 211, 221, 221, 200, 152, 206, 209, 203, 209, 218, 212, 221 }, 184));
                return;
            }

            _0x8ff0f470 = true;
            _0xa4f9701d(true);
            WLog(_0x893dd4c5._0x4756ee13(new byte[43] { 143, 189, 186, 142, 177, 189, 175, 248, 180, 183, 185, 188, 177, 182, 191, 247, 170, 189, 188, 177, 170, 189, 187, 172, 177, 182, 191, 248, 245, 230, 248, 179, 189, 189, 168, 248, 174, 177, 171, 177, 186, 180, 189 }, 216));
        };
        _0x187b720c.OnPageCommitted += (_0x1256e783, _0x95f0bc89) =>
        {
            if (_0x57aff127 && IsAboutBlank(_0x95f0bc89))
                return;
            WLog(_0x893dd4c5._0x4756ee13(new byte[31] { 133, 169, 161, 166, 232, 159, 173, 170, 158, 161, 173, 191, 232, 135, 166, 152, 169, 175, 173, 139, 167, 165, 165, 161, 188, 188, 173, 172, 242, 232, 227 }, 200) + (Time.realtimeSinceStartup - _0x357e8593).ToString(_0x893dd4c5._0x4756ee13(new byte[5] { 139, 149, 139, 139, 139 }, 187)) + _0x893dd4c5._0x4756ee13(new byte[2] { 224, 179 }, 147) + _0x95f0bc89);
            if (!firstLoadShown && IsHttpUrl(_0x95f0bc89))
            {
                firstLoadShown = true;
                _0x8ff0f470 = false;
                _0xa4f9701d(false);
                _0x9a4ce814();
                _0x11745bf5();
                _0x1256e783.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xe280eb0a(_0x893dd4c5._0x4756ee13(new byte[9] { 4, 5, 44, 28, 3, 22, 29, 22, 23 }, 115));
                WLog(_0x893dd4c5._0x4756ee13(new byte[39] { 99, 79, 71, 64, 14, 121, 75, 76, 120, 71, 75, 89, 14, 93, 70, 65, 89, 64, 14, 65, 64, 14, 77, 65, 67, 67, 71, 90, 90, 75, 74, 14, 77, 65, 64, 90, 75, 64, 90 }, 46));
            }
        };
        _0x187b720c.OnPageProgressChanged += (_0x1256e783, _0xaf6f3734) =>
        {
            if (_0x57aff127)
                return;
            if (!firstLoadShown && _0xaf6f3734 >= 0.65f)
            {
                firstLoadShown = true;
                _0x8ff0f470 = false;
                _0xa4f9701d(false);
                _0x9a4ce814();
                _0x11745bf5();
                _0x1256e783.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xe280eb0a(_0x893dd4c5._0x4756ee13(new byte[9] { 99, 98, 75, 123, 100, 113, 122, 113, 112 }, 20));
                WLog(_0x893dd4c5._0x4756ee13(new byte[32] { 132, 168, 160, 167, 233, 158, 172, 171, 159, 160, 172, 190, 233, 186, 161, 166, 190, 167, 233, 171, 176, 233, 185, 187, 166, 174, 187, 172, 186, 186, 243, 233 }, 201) + _0xaf6f3734);
            }
        };
        _0x187b720c.OnPageFinished += (_0x1256e783, _0x2526ff33, _0x95f0bc89) =>
        {
            if (_0x57aff127 && IsAboutBlank(_0x95f0bc89))
            {
                _0x57aff127 = false;
                WLog(_0x893dd4c5._0x4756ee13(new byte[28] { 144, 178, 165, 183, 161, 178, 173, 224, 161, 162, 175, 181, 180, 250, 162, 172, 161, 174, 171, 224, 166, 169, 174, 169, 179, 168, 165, 164 }, 192));
                return;
            }

            WLog(_0x893dd4c5._0x4756ee13(new byte[24] { 238, 194, 202, 205, 131, 244, 198, 193, 245, 202, 198, 212, 131, 229, 202, 205, 202, 208, 203, 198, 199, 153, 131, 136 }, 163) + (Time.realtimeSinceStartup - _0x357e8593).ToString(_0x893dd4c5._0x4756ee13(new byte[5] { 179, 173, 179, 179, 179 }, 131)) + _0x893dd4c5._0x4756ee13(new byte[7] { 20, 71, 4, 8, 3, 2, 90 }, 103) + _0x2526ff33 + _0x893dd4c5._0x4756ee13(new byte[5] { 106, 63, 56, 38, 119 }, 74) + _0x95f0bc89);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x8ff0f470 = false;
                _0xa4f9701d(false);
                _0x9a4ce814();
                _0x11745bf5();
                _0x1256e783.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xe280eb0a(_0x893dd4c5._0x4756ee13(new byte[9] { 227, 226, 203, 251, 228, 241, 250, 241, 240 }, 148));
                WLog(_0x893dd4c5._0x4756ee13(new byte[33] { 227, 207, 199, 192, 142, 249, 203, 204, 248, 199, 203, 217, 142, 200, 199, 220, 221, 218, 142, 194, 193, 207, 202, 142, 205, 193, 195, 222, 194, 203, 218, 203, 202 }, 174));
            }
            else if (_0x8ff0f470)
            {
                _0x8ff0f470 = false;
                _0xa4f9701d(false);
                _0x1256e783.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x893dd4c5._0x4756ee13(new byte[40] { 200, 228, 236, 235, 165, 210, 224, 231, 211, 236, 224, 242, 165, 214, 237, 234, 242, 165, 228, 227, 241, 224, 247, 165, 233, 234, 228, 225, 236, 235, 226, 165, 227, 236, 235, 236, 246, 237, 224, 225 }, 133));
            }
            else
            {
                _0xa4f9701d(false);
            }

            if (_0x81cb971e && !IsGoogleAuthFlowUrl(_0x95f0bc89) && !IsGoogleAuthFlowUrl(_0x95f0bc89))
            {
                WLog(_0x893dd4c5._0x4756ee13(new byte[48] { 136, 160, 160, 168, 163, 170, 239, 174, 186, 187, 167, 239, 188, 170, 170, 162, 188, 239, 169, 166, 161, 166, 188, 167, 170, 171, 239, 226, 241, 239, 189, 170, 188, 187, 160, 189, 170, 239, 171, 170, 169, 174, 186, 163, 187, 239, 154, 142 }, 207));
                _0x81cb971e = false;
                _0x5f57ded1.SetUserAgent("");
            }
        };
        _0x187b720c.OnShouldClose += _0x1256e783 =>
        {
            WLog(_0x893dd4c5._0x4756ee13(new byte[41] { 241, 254, 207, 217, 222, 247, 138, 231, 203, 195, 196, 138, 253, 207, 200, 252, 195, 207, 221, 138, 229, 196, 249, 194, 197, 223, 198, 206, 233, 198, 197, 217, 207, 138, 195, 196, 220, 197, 193, 207, 206 }, 170));
            _0x32db6a05();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x187b720c.SetPopupPageEventEnabled(true);
        bool _0xe3842ebe = false;
        bool _0xa0162e65 = false;
        _0x187b720c.OnMultipleWindowOpened += (_0x1256e783, _0x3563ac23) =>
        {
            _0x1256e783.ScrollTo(0, 0, false);
            WLog(_0x893dd4c5._0x4756ee13(new byte[43] { 37, 42, 27, 13, 10, 35, 94, 51, 31, 23, 16, 94, 41, 27, 28, 40, 23, 27, 9, 94, 51, 11, 18, 10, 23, 14, 18, 27, 41, 23, 16, 26, 17, 9, 94, 49, 14, 27, 16, 27, 26, 68, 94 }, 126) + _0x3563ac23);
            var _0x1bd30160 = _0x187b720c.GetPopupWindow(_0x3563ac23);
            if (_0x1bd30160 == null)
                return;
            _0xe57a15f9.Add(_0x1bd30160);
            Debug.Log($"[Test] Popup ID: {_0x1bd30160.Id}");
            _0x1bd30160.OnPageStarted += (_0xe07581f5, _0x95f0bc89) =>
            {
                WLog(_0x893dd4c5._0x4756ee13(new byte[36] { 11, 4, 53, 35, 36, 13, 112, 0, 63, 32, 37, 32, 112, 7, 53, 50, 6, 57, 53, 39, 112, 31, 62, 0, 49, 55, 53, 3, 36, 49, 34, 36, 53, 52, 106, 112 }, 80) + _0x95f0bc89);
                _0x21cfa60a = 0;
                if (string.IsNullOrEmpty(_0x95f0bc89) || IsAboutBlank(_0x95f0bc89))
                    return;
                if (IsGoogleAuthFlowUrl(_0x95f0bc89))
                {
                    WLog(_0x893dd4c5._0x4756ee13(new byte[57] { 201, 198, 247, 225, 230, 207, 178, 194, 253, 226, 231, 226, 178, 213, 253, 253, 245, 254, 247, 178, 243, 231, 230, 250, 178, 244, 254, 253, 229, 178, 191, 172, 178, 225, 226, 253, 253, 244, 178, 213, 253, 253, 245, 254, 247, 178, 209, 250, 224, 253, 255, 247, 178, 199, 211, 168, 178 }, 146) + _0x95f0bc89);
                    _0xe3842ebe = false;
                    _0xe7d0c301();
                    if (_0xe07581f5 != null && _0xe07581f5.IsAlive)
                        _0xe07581f5.EvaluateJavaScript(_0x5388e0c6());
                    return;
                }

                if (_0x5f57ded1 == null)
                    return;
                if (!_0xe3842ebe)
                {
                    _0xe3842ebe = true;
                    _0x5f57ded1.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x893dd4c5._0x4756ee13(new byte[39] { 182, 185, 136, 158, 153, 176, 205, 189, 130, 157, 152, 157, 205, 140, 157, 157, 129, 148, 205, 186, 132, 131, 137, 130, 154, 158, 205, 137, 136, 158, 134, 153, 130, 157, 205, 184, 172, 215, 205 }, 237) + _0x95f0bc89);
                }

                if (_0xe07581f5 != null && _0xe07581f5.IsAlive)
                    _0xe07581f5.EvaluateJavaScript(_0x397afbc6());
                if (!_0xa0162e65 && _0xe07581f5 != null && _0xe07581f5.IsAlive && IsHttpUrl(_0x95f0bc89))
                {
                    _0xa0162e65 = true;
                }
            };
            _0x1bd30160.OnPageFinished += (_0xe07581f5, _0x60af8e6f) =>
            {
                string _0x4b055c17 = _0x60af8e6f != null ? _0x60af8e6f.data : string.Empty;
                WLog(_0x893dd4c5._0x4756ee13(new byte[35] { 197, 202, 251, 237, 234, 195, 190, 206, 241, 238, 235, 238, 190, 201, 251, 252, 200, 247, 251, 233, 190, 216, 247, 240, 247, 237, 246, 251, 250, 164, 190, 235, 236, 242, 163 }, 158) + _0x4b055c17);
                if (_0xe07581f5 == null || !_0xe07581f5.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x4b055c17))
                {
                    _0xe7d0c301();
                    _0xe07581f5.EvaluateJavaScript(_0x5388e0c6());
                    return;
                }

                if (!_0xe3842ebe)
                    return;
                _0xe07581f5.EvaluateJavaScript(_0x397afbc6());
            };
        };
        _0x187b720c.OnMultipleWindowClosed += (_0x1256e783, _0x3563ac23) =>
        {
            _0xe57a15f9.RemoveAll(_0x103a8fc7 => _0x103a8fc7 == null || _0x103a8fc7.Id == _0x3563ac23 || !_0x103a8fc7.IsAlive);
            _0xa4f9701d(false);
            if (_0xe57a15f9.Count == 0 && _0x5f57ded1 != null)
            {
                _0xe3842ebe = false;
                _0xa0162e65 = false;
                _0x82b1d95c();
            }

            WLog(_0x893dd4c5._0x4756ee13(new byte[43] { 78, 65, 112, 102, 97, 72, 53, 88, 116, 124, 123, 53, 66, 112, 119, 67, 124, 112, 98, 53, 88, 96, 121, 97, 124, 101, 121, 112, 66, 124, 123, 113, 122, 98, 53, 86, 121, 122, 102, 112, 113, 47, 53 }, 21) + _0x3563ac23);
        };
        _0x187b720c.RegisterOnRequestMediaCapturePermission(_0xa6e4b339 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    internal bool isDestroyedForce = false;
    internal Rect lastSafe = Rect.zero;
    private string _0x75b655c2 = "";
    private string _0xac55f0b9;
    private async void Start()
    {
        await _0x0522357a();
    }

    private string _0x21e9d7dc = "";
    private string _0x919b307f = "";
    internal bool ContainsIgnoreCase(string _0x40871abe, string _0x8de1a578)
    {
        if (string.IsNullOrEmpty(_0x40871abe) || string.IsNullOrEmpty(_0x8de1a578))
            return false;
        return _0x40871abe.IndexOf(_0x8de1a578, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0xfa56fcf5 = "";
    private async Task<bool> _0x867c7f46()
    {
        {
#if B_LOGS
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[37] { 62, 49, 0, 22, 17, 56, 69, 54, 12, 2, 11, 44, 11, 48, 11, 12, 17, 28, 54, 0, 23, 19, 12, 6, 0, 22, 36, 11, 10, 11, 28, 8, 10, 16, 22, 9, 28 }, 101));
#endif
        }

        try
        {
            var _0x1d5a1b15 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x1d5a1b15);
            {
#if B_LOGS
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[32] { 188, 179, 130, 148, 147, 186, 199, 178, 137, 142, 147, 158, 180, 130, 149, 145, 142, 132, 130, 148, 199, 174, 137, 142, 147, 142, 134, 139, 142, 157, 130, 131 }, 231));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[20] { 235, 250, 236, 235, 159, 234, 209, 214, 203, 198, 236, 218, 205, 201, 214, 220, 218, 204, 133, 159 }, 191) + ex.Message);
#endif
            }

            _0x048cc6fe?._0xa8b5b03d();
            return true;
        }

        bool _0x454bc4be = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x454bc4be = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x893dd4c5._0x4756ee13(new byte[37] { 102, 105, 88, 78, 73, 96, 29, 110, 84, 90, 83, 16, 84, 83, 29, 124, 83, 82, 83, 68, 80, 82, 72, 78, 19, 29, 109, 81, 92, 68, 88, 79, 29, 116, 121, 7, 29 }, 61) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xf9b182fa = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x893dd4c5._0x4756ee13(new byte[25] { 188, 173, 187, 188, 200, 187, 129, 143, 134, 197, 129, 134, 200, 169, 157, 156, 128, 200, 173, 186, 186, 167, 186, 210, 200 }, 232) + ex.Message);
#endif
                }

                _0x048cc6fe?._0xa8b5b03d();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x893dd4c5._0x4756ee13(new byte[28] { 166, 183, 161, 166, 210, 161, 155, 149, 156, 223, 155, 156, 210, 160, 151, 131, 135, 151, 129, 134, 210, 183, 160, 160, 189, 160, 200, 210 }, 242) + ex.Message);
#endif
                }

                _0x048cc6fe?._0xa8b5b03d();
                return true;
            }
        }
        while (!_0x454bc4be);
        return false;
    }

    internal bool _0xcba90471(string _0x6905beea)
    {
        return _0x6905beea.StartsWith(_0x893dd4c5._0x4756ee13(new byte[9] { 232, 228, 247, 238, 224, 241, 191, 170, 170 }, 133), StringComparison.OrdinalIgnoreCase) || _0x6905beea.StartsWith(_0x893dd4c5._0x4756ee13(new byte[24] { 49, 45, 45, 41, 42, 99, 118, 118, 41, 53, 56, 32, 119, 62, 54, 54, 62, 53, 60, 119, 58, 54, 52, 118 }, 89), StringComparison.OrdinalIgnoreCase) || _0x6905beea.StartsWith(_0x893dd4c5._0x4756ee13(new byte[23] { 0, 28, 28, 24, 82, 71, 71, 24, 4, 9, 17, 70, 15, 7, 7, 15, 4, 13, 70, 11, 7, 5, 71 }, 104), StringComparison.OrdinalIgnoreCase);
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x5f57ded1 = null;
    internal bool IsGoogleAuthFlowUrl(string _0x60ee1bca)
    {
        if (string.IsNullOrEmpty(_0x60ee1bca))
            return false;
        return _0x60ee1bca.IndexOf(_0x893dd4c5._0x4756ee13(new byte[19] { 180, 182, 182, 186, 160, 187, 161, 166, 251, 178, 186, 186, 178, 185, 176, 251, 182, 186, 184 }, 213), StringComparison.OrdinalIgnoreCase) >= 0 || _0x60ee1bca.IndexOf(_0x893dd4c5._0x4756ee13(new byte[16] { 48, 50, 50, 62, 36, 63, 37, 34, 127, 54, 62, 62, 54, 61, 52, 127 }, 81), StringComparison.OrdinalIgnoreCase) >= 0 || _0x60ee1bca.IndexOf(_0x893dd4c5._0x4756ee13(new byte[21] { 55, 63, 63, 55, 60, 53, 37, 35, 53, 34, 51, 63, 62, 36, 53, 62, 36, 126, 51, 63, 61 }, 80), StringComparison.OrdinalIgnoreCase) >= 0 || _0x60ee1bca.IndexOf(_0x893dd4c5._0x4756ee13(new byte[11] { 145, 133, 130, 151, 130, 159, 149, 216, 149, 153, 155 }, 246), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private int _0x7f19bfa4 = 5, _0xa4a6c66d = 5, _0x58c2b77b = 5, _0x57636163 = 5;
    private IEnumerator _0x45090e79(IEnumerator _0x6d4ba586, TaskCompletionSource<bool> _0x62a8d515)
    {
        yield return _0x6d4ba586;
        _0x62a8d515.SetResult(true);
    }

    private void _0x82b1d95c()
    {
        if (_0x5f57ded1 == null)
            return;
        if (_0x81cb971e)
            _0x5f57ded1.SetUserAgent(_0xe23a5340());
        else
            _0x5f57ded1.SetUserAgent("");
    }

    private void _0xe7d0c301()
    {
        _0x81cb971e = true;
        if (_0x5f57ded1 != null)
            _0x5f57ded1.SetUserAgent(_0xe23a5340());
    }

    private IEnumerator _0x45c44c3b(string _0x3ff85f2f)
    {
        if (_0x5f57ded1 != null && _0xfceb9fa1)
            yield break;
        _0x5f57ded1 = gameObject.AddComponent<UniWebView>();
        _0xc541b69d(_0x5f57ded1);
        _0x15a34f16(_0x5f57ded1);
        _0x5f57ded1.BackgroundColor = Color.clear;
        var _0xb5c34d5b = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x11745bf5();
        yield return new WaitForEndOfFrame();
        _0xfceb9fa1 = true;
        _0x0cc4c1b8();
        _0xa4f9701d(true);
        _0x57aff127 = false;
        _0x81cb971e = false;
        _0xe57a15f9.Clear();
        _0xec6c768e = -1;
        firstLoadShown = false;
        _0x8ff0f470 = false;
        _0x3a697159 = false;
        _0x5f57ded1.SetUserAgent("");
        _0x357e8593 = Time.realtimeSinceStartup;
        _0x5f57ded1.Stop();
        _0x5f57ded1.Load(_0x3ff85f2f);
        _0x5f57ded1.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x893dd4c5._0x4756ee13(new byte[25] { 130, 174, 166, 161, 239, 152, 170, 173, 153, 166, 170, 184, 239, 134, 161, 166, 187, 166, 174, 163, 239, 156, 167, 160, 184 }, 207));
    }

    private string _0x417303d5()
    {
        string _0x47ce69c0 = _0x893dd4c5._0x4756ee13(new byte[62] { 58, 57, 56, 63, 62, 61, 60, 51, 50, 49, 48, 55, 54, 53, 52, 43, 42, 41, 40, 47, 46, 45, 44, 35, 34, 33, 26, 25, 24, 31, 30, 29, 28, 19, 18, 17, 16, 23, 22, 21, 20, 11, 10, 9, 8, 15, 14, 13, 12, 3, 2, 1, 107, 106, 105, 104, 111, 110, 109, 108, 99, 98 }, 91);
        System.Random _0x599b6b09 = new System.Random();
        int _0x02321bcc = _0x599b6b09.Next(8, 16);
        return new string (Enumerable.Repeat(_0x47ce69c0, _0x02321bcc).Select(_0xe5e8647e => _0xe5e8647e[_0x599b6b09.Next(_0xe5e8647e.Length)]).ToArray());
    }

    private string _0xa0191fe8 = "";
    private readonly List<UniWebViewPopup> _0xe57a15f9 = new List<UniWebViewPopup>();
    private string _0x41ab7911 = "";
    private string _0xc67ac6be = "";
    private float _0x357e8593 = 0f;
    private string _0xb60ff212()
    {
        float _0xe05af8f3 = Time.realtimeSinceStartup;
        if (_0xe05af8f3 < 0f)
            _0xe05af8f3 = 0f;
        int _0xa8e895d2 = (int)(_0xe05af8f3 * 1000f);
        int _0x49ab6e4a = _0xa8e895d2 / 60000;
        int _0xb5994b37 = (_0xa8e895d2 / 1000) % 60;
        int _0xaafb0b6f = _0xa8e895d2 % 1000;
        return string.Format(_0x893dd4c5._0x4756ee13(new byte[21] { 152, 211, 217, 211, 211, 158, 217, 152, 210, 217, 211, 211, 158, 217, 152, 209, 217, 211, 211, 211, 158 }, 227), _0x49ab6e4a, _0xb5994b37, _0xaafb0b6f);
    }

    private void OnApplicationPause(bool _0x351b8754)
    {
        isApplicationPause = _0x351b8754;
    }

    public void _0xa8b5b03d()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[18] { 142, 129, 176, 166, 161, 136, 245, 153, 180, 160, 187, 182, 189, 245, 146, 180, 184, 176 }, 213));
#endif
        }

        _0x0c0418a5.Instance?._0x56481bb2();
        _0xe7358e6f.Instance._0x4d3ae7c9(_0x20971818._0x9d65fd4d.DEFAULT);
    }

    private bool _0xb6a48890(string _0x06fdfec1, string _0xe4092850)
    {
        string _0xf8f98bdc = _0x322aed22(_0x06fdfec1);
        if (string.IsNullOrEmpty(_0xf8f98bdc))
            _0xf8f98bdc = _0xe4092850;
        if (_0xd7a61572(_0xf8f98bdc))
            return true;
        string _0xc8dd35a4 = string.IsNullOrEmpty(_0xf8f98bdc) ? _0x893dd4c5._0x4756ee13(new byte[29] { 169, 181, 181, 177, 178, 251, 238, 238, 177, 173, 160, 184, 239, 166, 174, 174, 166, 173, 164, 239, 162, 174, 172, 238, 178, 181, 174, 179, 164 }, 193) : _0x893dd4c5._0x4756ee13(new byte[46] { 251, 231, 231, 227, 224, 169, 188, 188, 227, 255, 242, 234, 189, 244, 252, 252, 244, 255, 246, 189, 240, 252, 254, 188, 224, 231, 252, 225, 246, 188, 242, 227, 227, 224, 188, 247, 246, 231, 242, 250, 255, 224, 172, 250, 247, 174 }, 147) + _0xf8f98bdc;
        WLog(_0x893dd4c5._0x4756ee13(new byte[35] { 143, 164, 190, 163, 161, 169, 128, 165, 167, 169, 236, 161, 173, 190, 167, 169, 184, 236, 170, 173, 160, 160, 174, 173, 175, 167, 236, 173, 191, 236, 187, 169, 174, 246, 236 }, 204) + _0xc8dd35a4);
        return _0xfbe909cd(_0xc8dd35a4);
    }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x95995d80(string _0xecc64b8e, string _0x8b8fb773)
    {
        try
        {
            using var _0xa795f76f = Aes.Create();
            _0xa795f76f.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x8b8fb773));
            _0xa795f76f.GenerateIV();
            using var _0x50d516b6 = new MemoryStream();
            _0x50d516b6.Write(_0xa795f76f.IV, 0, _0xa795f76f.IV.Length);
            using (var _0xf21e517a = new CryptoStream(_0x50d516b6, _0xa795f76f.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x1212ebac = Encoding.UTF8.GetBytes(_0xecc64b8e);
                _0xf21e517a.Write(_0x1212ebac, 0, _0x1212ebac.Length);
                _0xf21e517a.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x50d516b6.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private bool _0x6634d76e(int _0xd6b53f21, string _0xc32ab5dd, string _0x07721085)
    {
        if (string.IsNullOrEmpty(_0x07721085))
            return false;
        if (!IsHttpUrl(_0x07721085))
            return true;
        if (string.IsNullOrEmpty(_0xc32ab5dd))
            return false;
        return _0xc32ab5dd.IndexOf(_0x893dd4c5._0x4756ee13(new byte[20] { 205, 218, 218, 215, 203, 199, 198, 198, 205, 203, 220, 193, 199, 198, 215, 218, 205, 219, 205, 220 }, 136), StringComparison.OrdinalIgnoreCase) >= 0 || _0xc32ab5dd.IndexOf(_0x893dd4c5._0x4756ee13(new byte[22] { 196, 211, 211, 222, 194, 206, 207, 207, 196, 194, 213, 200, 206, 207, 222, 211, 196, 199, 212, 210, 196, 197 }, 129), StringComparison.OrdinalIgnoreCase) >= 0 || _0xc32ab5dd.IndexOf(_0x893dd4c5._0x4756ee13(new byte[21] { 16, 7, 7, 10, 22, 26, 27, 27, 16, 22, 1, 28, 26, 27, 10, 22, 25, 26, 6, 16, 17 }, 85), StringComparison.OrdinalIgnoreCase) >= 0 || _0xc32ab5dd.IndexOf(_0x893dd4c5._0x4756ee13(new byte[22] { 94, 73, 73, 68, 78, 85, 80, 85, 84, 76, 85, 68, 78, 73, 87, 68, 72, 88, 83, 94, 86, 94 }, 27), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x2187d8f0 = "";
    internal bool firstLoadShown = false;
    private void WLog(string _0x9d70b386)
    {
#if B_LOGS
        {
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[7] { 23, 24, 41, 63, 56, 17, 108 }, 76) + _0x9d70b386);
        }
#endif
    }

    // WS_SOURCE MONO
    public static _0x049ebdfd _0x048cc6fe { get; private set; }

    private bool _0x8ff0f470 = false;
    private async Task _0xe280eb0a(string _0x21238e0f)
    {
        if (_0x4d1e0303 || string.IsNullOrEmpty(_0xf9b182fa) || string.IsNullOrEmpty(_0x21238e0f) || _0xf5295ddd)
            return;
        _0x4d1e0303 = true;
        try
        {
            JObject _0x448a3b2c = _0xf38719ef(_0x21238e0f, _0xf9b182fa, _0xb60ff212());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x21238e0f} payload: {_0x448a3b2c}");
                }
#endif
            }

            var _0x1d0bbbe0 = _0x95995d80(_0x448a3b2c.ToString(), _0xf9b182fa);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x893dd4c5._0x4756ee13(new byte[4] { 121, 122, 116, 113 }, 21) + _0xf9b182fa, _0x1d0bbbe0 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[24] { 127, 112, 97, 119, 112, 121, 4, 104, 75, 69, 64, 4, 84, 69, 87, 87, 4, 65, 86, 86, 75, 86, 30, 4 }, 36) + e.Message);
#endif
            }
        }
    }

    private string _0x3330b35e = "";
    private void OnApplicationFocus(bool _0x928549f5)
    {
        isApplicationFocus = _0x928549f5;
        if (_0x928549f5 && _0xfceb9fa1)
        {
            _0x931633c6();
        }
    }

    private Action _0x4600d11f;
    private string _0xb5878e79 = "";
    private async Task<bool> _0xfb128f71()
    {
        {
#if B_LOGS
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[29] { 16, 31, 46, 56, 63, 22, 107, 2, 56, 27, 57, 34, 61, 42, 40, 50, 10, 37, 47, 24, 42, 61, 46, 47, 8, 35, 46, 40, 32 }, 75));
#endif
        }

        string _0x953dfaad = "";
        for (int _0xb8de323c = 0; _0xb8de323c < 2; _0xb8de323c++)
        {
            if (await _0xee3332f1(1, 100))
            {
                await _0xe280eb0a(_0x893dd4c5._0x4756ee13(new byte[7] { 53, 59, 56, 52, 60, 50, 51 }, 87));
                _0xa8b5b03d();
                return true;
            }

            _0x953dfaad = await _0x0c0b04cd(1, 100);
            if (!string.IsNullOrEmpty(_0x953dfaad))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x953dfaad))
            {
                if (!string.IsNullOrEmpty(_0xb114febf))
                {
                    _0x953dfaad = _0x6786aea7(_0x953dfaad, _0xb114febf);
                    {
#if B_LOGS
                        Debug.Log(_0x893dd4c5._0x4756ee13(new byte[53] { 211, 220, 237, 251, 252, 213, 168, 203, 233, 235, 224, 237, 236, 168, 238, 225, 230, 233, 228, 221, 250, 228, 168, 255, 225, 252, 224, 168, 251, 237, 230, 236, 225, 236, 168, 106, 14, 26, 168, 251, 224, 231, 255, 168, 223, 237, 234, 222, 225, 237, 255, 178, 168 }, 136) + _0x953dfaad);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x893dd4c5._0x4756ee13(new byte[39] { 124, 115, 66, 84, 83, 122, 7, 100, 70, 68, 79, 66, 67, 7, 65, 78, 73, 70, 75, 114, 85, 75, 7, 197, 161, 181, 7, 84, 79, 72, 80, 7, 112, 66, 69, 113, 78, 66, 80 }, 39));
#endif
                    }
                }

                _0xf5295ddd = true;
                _0x6ad69106(_0x953dfaad);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x893dd4c5._0x4756ee13(new byte[44] { 177, 190, 143, 153, 158, 183, 202, 175, 146, 137, 143, 154, 158, 131, 133, 132, 202, 157, 130, 131, 134, 143, 202, 137, 130, 143, 137, 129, 131, 132, 141, 202, 153, 139, 156, 143, 142, 202, 134, 131, 132, 129, 208, 202 }, 234) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private IEnumerator _0x22a87537(string _0x104e7190)
    {
        if (Permission.HasUserAuthorizedPermission(_0x104e7190))
            yield break;
        bool _0x39b1d4c6 = false;
        var _0xcd944130 = new PermissionCallbacks();
        _0xcd944130.PermissionGranted += _0x2aab4807 => _0x39b1d4c6 = true;
        _0xcd944130.PermissionDenied += _0x2aab4807 => _0x39b1d4c6 = true;
        Permission.RequestUserPermission(_0x104e7190, _0xcd944130);
        yield return new WaitUntil(() => _0x39b1d4c6);
    }

    private string _0x1b35e579 = "";
    private string _0xe23a5340()
    {
        if (string.IsNullOrEmpty(_0x1b35e579) && _0x5f57ded1 != null)
            _0x1b35e579 = _0x5f57ded1.GetUserAgent();
        if (string.IsNullOrEmpty(_0x1b35e579))
            return string.Empty;
        string _0xb880c4b9 = Regex.Replace(_0x1b35e579, _0x893dd4c5._0x4756ee13(new byte[11] { 118, 89, 0, 17, 118, 89, 0, 93, 92, 118, 72 }, 42), string.Empty);
        _0xb880c4b9 = Regex.Replace(_0xb880c4b9, _0x893dd4c5._0x4756ee13(new byte[15] { 251, 212, 140, 229, 210, 206, 203, 195, 136, 252, 249, 156, 142, 250, 140 }, 167), string.Empty);
        _0xb880c4b9 = Regex.Replace(_0xb880c4b9, _0x893dd4c5._0x4756ee13(new byte[15] { 121, 74, 93, 92, 70, 64, 65, 0, 27, 115, 1, 31, 115, 92, 5 }, 47), string.Empty);
        return Regex.Replace(_0xb880c4b9, _0x893dd4c5._0x4756ee13(new byte[6] { 214, 249, 241, 184, 166, 247 }, 138), _0x893dd4c5._0x4756ee13(new byte[1] { 77 }, 109)).Trim();
    }

    private string _0xb0faec9f { get; set; }

    internal Button _0x0adab5d5(string _0xdbc8c302, Transform _0x5232cca9)
    {
        var _0xb43849e7 = new GameObject(_0xdbc8c302 + _0x893dd4c5._0x4756ee13(new byte[3] { 151, 161, 187 }, 213), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xac5c302d = _0xb43849e7.GetComponent<RectTransform>();
        _0xac5c302d.SetParent(_0x5232cca9, false);
        var _0xf356d3bf = _0xb43849e7.GetComponent<Image>();
        _0xf356d3bf.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xb46311fd = _0xb43849e7.GetComponent<Button>();
        var _0x9f91bfad = _0xb46311fd.colors;
        _0x9f91bfad.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x9f91bfad.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xb46311fd.colors = _0x9f91bfad;
        var _0x7d7a8e9d = new GameObject(_0x893dd4c5._0x4756ee13(new byte[4] { 180, 133, 152, 148 }, 224), typeof(RectTransform), typeof(Text));
        var _0x9fc20d42 = _0x7d7a8e9d.GetComponent<RectTransform>();
        _0x9fc20d42.SetParent(_0xb43849e7.transform, false);
        _0x9fc20d42.anchorMin = Vector2.zero;
        _0x9fc20d42.anchorMax = Vector2.one;
        _0x9fc20d42.offsetMin = _0x9fc20d42.offsetMax = Vector2.zero;
        var _0x2d7ae4f2 = _0x7d7a8e9d.GetComponent<Text>();
        _0x2d7ae4f2.text = _0xdbc8c302;
        _0x2d7ae4f2.alignment = TextAnchor.MiddleCenter;
        _0x2d7ae4f2.color = Color.black;
        _0x2d7ae4f2.font = Resources.GetBuiltinResource<Font>(_0x893dd4c5._0x4756ee13(new byte[9] { 140, 191, 164, 172, 161, 227, 185, 185, 171 }, 205));
        _0x2d7ae4f2.fontSize = 28;
        WLog(_0x893dd4c5._0x4756ee13(new byte[14] { 92, 109, 122, 126, 107, 122, 93, 106, 107, 107, 112, 113, 63, 56 }, 31) + _0xdbc8c302 + _0x893dd4c5._0x4756ee13(new byte[1] { 12 }, 43));
        return _0xb46311fd;
    }

    private string Decrypt(string _0x8087febf, string _0x07ae6e5c)
    {
        try
        {
            var _0xab93f372 = Convert.FromBase64String(_0x8087febf);
            using var _0xa9e60dc3 = Aes.Create();
            _0xa9e60dc3.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x07ae6e5c));
            var _0x0c6b8d1c = new byte[16];
            Buffer.BlockCopy(_0xab93f372, 0, _0x0c6b8d1c, 0, 16);
            _0xa9e60dc3.IV = _0x0c6b8d1c;
            using var _0x1c7803dd = new MemoryStream(_0xab93f372, 16, _0xab93f372.Length - 16);
            using var _0x7f2bc16d = new CryptoStream(_0x1c7803dd, _0xa9e60dc3.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x2f609d9b = new StreamReader(_0x7f2bc16d, Encoding.UTF8);
            return _0x2f609d9b.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xa8b5b03d();
    }

    private IEnumerator _0x75b3611f(Dictionary<string, object> _0x47dce644)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[30] { 165, 170, 155, 141, 138, 163, 222, 184, 155, 138, 157, 150, 222, 187, 134, 138, 140, 159, 222, 174, 139, 141, 150, 222, 186, 159, 138, 159, 196, 222 }, 254) + string.Join(_0x893dd4c5._0x4756ee13(new byte[1] { 125 }, 116), _0x47dce644));
#endif
            }
        }

        string _0xa9e4a377 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x47dce644 != null && _0x47dce644.TryGetValue(_0x893dd4c5._0x4756ee13(new byte[16] { 42, 43, 48, 45, 34, 45, 39, 37, 48, 45, 43, 42, 0, 37, 48, 37 }, 68), out var raw))
        {
            try
            {
                var _0x8a2924bd = raw?.ToString();
                var _0x1d59486a = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x8a2924bd);
                if (_0x1d59486a != null && _0x1d59486a.TryGetValue(_0x893dd4c5._0x4756ee13(new byte[6] { 44, 58, 49, 59, 54, 59 }, 95), out var val))
                {
                    _0xa9e4a377 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x893dd4c5._0x4756ee13(new byte[30] { 213, 218, 235, 253, 250, 174, 222, 251, 253, 230, 211, 174, 196, 221, 193, 192, 174, 254, 239, 252, 253, 235, 174, 235, 252, 252, 225, 252, 180, 174 }, 142) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xa9e4a377) && _0x47dce644 != null && _0x47dce644.TryGetValue(_0x893dd4c5._0x4756ee13(new byte[6] { 114, 100, 111, 101, 104, 101 }, 1), out var lab))
        {
            _0xa9e4a377 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[38] { 20, 27, 42, 60, 59, 111, 31, 58, 60, 39, 18, 111, 9, 42, 59, 44, 39, 42, 43, 111, 60, 42, 33, 43, 38, 43, 111, 41, 61, 32, 34, 111, 37, 60, 32, 33, 117, 111 }, 79) + _0xa9e4a377);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xa9e4a377))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[38] { 193, 206, 255, 233, 238, 186, 202, 239, 233, 242, 199, 186, 205, 251, 243, 238, 186, 238, 245, 186, 245, 234, 255, 244, 186, 237, 243, 238, 242, 186, 233, 255, 244, 254, 243, 254, 160, 186 }, 154) + _0xa9e4a377);
            }
#endif
        }

        _0xb114febf = _0xa9e4a377;
        yield return new WaitUntil(() => _0xfceb9fa1);
        var _0x74eb6bed = _0x0c0b04cd(2, 100);
        yield return new WaitUntil(() => _0x74eb6bed.IsCompleted);
        string _0x1f470d4d = _0x74eb6bed.Result;
        if (!string.IsNullOrEmpty(_0x1f470d4d))
        {
            string _0x7e56817a = _0x6786aea7(_0x1f470d4d, _0xa9e4a377);
            {
#if B_LOGS
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[33] { 33, 46, 31, 9, 14, 90, 42, 15, 9, 18, 39, 90, 40, 31, 22, 21, 27, 30, 90, 45, 31, 24, 44, 19, 31, 13, 90, 13, 19, 14, 18, 64, 90 }, 122) + _0x7e56817a);
#endif
            }

            _0x5f57ded1.Load(_0x7e56817a);
        }
    }

    private void _0x1c2d1156(string _0xbd95f8e2)
    {
        bool _0xb0603b1c = !string.IsNullOrEmpty(_0xbd95f8e2);
        if (_0xb0603b1c)
        {
            {
#if B_LOGS
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[13] { 148, 155, 170, 188, 187, 146, 239, 156, 167, 160, 184, 245, 239 }, 207) + _0xbd95f8e2);
#endif
            }

            _0x6ad69106(_0xbd95f8e2);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[39] { 1, 14, 63, 41, 46, 7, 122, 28, 59, 54, 54, 56, 59, 57, 49, 122, 184, 220, 200, 122, 29, 59, 55, 63, 122, 114, 52, 53, 122, 60, 51, 52, 59, 54, 122, 15, 8, 22, 115 }, 90));
#endif
            }

            _0xa8b5b03d();
            return;
        }
    }

    private bool _0xcf76a27d = false;
    private bool _0xa5bea9c2()
    {
        var _0xae0e82b5 = Keyboard.current;
        return _0xae0e82b5 != null && _0xae0e82b5.escapeKey.wasPressedThisFrame;
    }

    private void _0xc541b69d(UniWebView _0xf8edef35)
    {
        _0xf8edef35.BackgroundColor = Color.clear;
        _0xf8edef35.SetSupportMultipleWindows(true, true);
        _0xf8edef35.SetBackButtonEnabled(false);
        _0x5f57ded1.SetUserAgent(_0xe23a5340());
    }

    // PART 3
    private string _0x6948b5ac()
    {
        try
        {
            var _0xce7ff6b7 = new AndroidJavaClass(_0x893dd4c5._0x4756ee13(new byte[30] { 178, 190, 188, 255, 164, 191, 184, 165, 168, 226, 181, 255, 161, 189, 176, 168, 180, 163, 255, 132, 191, 184, 165, 168, 129, 189, 176, 168, 180, 163 }, 209));
            var _0x7e2c9e7e = _0xce7ff6b7.GetStatic<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[15] { 232, 254, 249, 249, 238, 229, 255, 202, 232, 255, 226, 253, 226, 255, 242 }, 139));
            var _0x41c0c9bf = new AndroidJavaClass(_0x893dd4c5._0x4756ee13(new byte[57] { 129, 141, 143, 204, 133, 141, 141, 133, 142, 135, 204, 131, 140, 134, 144, 141, 139, 134, 204, 133, 143, 145, 204, 131, 134, 145, 204, 139, 134, 135, 140, 150, 139, 132, 139, 135, 144, 204, 163, 134, 148, 135, 144, 150, 139, 145, 139, 140, 133, 171, 134, 161, 142, 139, 135, 140, 150 }, 226));
            var _0x7ef60de6 = _0x41c0c9bf.CallStatic<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[20] { 244, 246, 231, 210, 247, 229, 246, 225, 231, 250, 224, 250, 253, 244, 218, 247, 218, 253, 245, 252 }, 147), _0x7e2c9e7e);
            var _0xf14c0f8a = _0x7ef60de6.Call<string>(_0x893dd4c5._0x4756ee13(new byte[5] { 194, 192, 209, 236, 193 }, 165));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xf14c0f8a}");
#endif
            }

            return string.IsNullOrEmpty(_0xf14c0f8a) ? "" : _0xf14c0f8a;
        }
        catch
        {
            return "";
        }
    }

    private string _0x397afbc6()
    {
        return _0x893dd4c5._0x4756ee13(new byte[12] { 199, 137, 154, 129, 140, 155, 134, 128, 129, 199, 198, 148 }, 239) + _0x893dd4c5._0x4756ee13(new byte[8] { 165, 178, 161, 243, 166, 178, 238, 244 }, 211) + WindowsDesktopUserAgent + _0x893dd4c5._0x4756ee13(new byte[2] { 232, 244 }, 207) + _0x893dd4c5._0x4756ee13(new byte[30] { 77, 90, 73, 27, 75, 73, 84, 79, 84, 6, 117, 90, 77, 82, 92, 90, 79, 84, 73, 21, 75, 73, 84, 79, 84, 79, 66, 75, 94, 0 }, 59) + _0x893dd4c5._0x4756ee13(new byte[121] { 100, 119, 108, 97, 118, 107, 109, 108, 34, 102, 103, 100, 42, 109, 96, 104, 46, 105, 103, 123, 46, 116, 99, 110, 43, 121, 118, 112, 123, 121, 77, 96, 104, 103, 97, 118, 44, 102, 103, 100, 107, 108, 103, 82, 112, 109, 114, 103, 112, 118, 123, 42, 109, 96, 104, 46, 105, 103, 123, 46, 121, 101, 103, 118, 56, 100, 119, 108, 97, 118, 107, 109, 108, 42, 43, 121, 112, 103, 118, 119, 112, 108, 34, 116, 99, 110, 57, 127, 46, 97, 109, 108, 100, 107, 101, 119, 112, 99, 96, 110, 103, 56, 118, 112, 119, 103, 127, 43, 57, 127, 97, 99, 118, 97, 106, 42, 103, 43, 121, 127, 127 }, 2) + _0x893dd4c5._0x4756ee13(new byte[26] { 187, 186, 185, 247, 175, 173, 176, 171, 176, 243, 248, 170, 172, 186, 173, 158, 184, 186, 177, 171, 248, 243, 170, 190, 246, 228 }, 223) + _0x893dd4c5._0x4756ee13(new byte[130] { 203, 202, 201, 135, 223, 221, 192, 219, 192, 131, 136, 206, 223, 223, 249, 202, 221, 220, 198, 192, 193, 136, 131, 136, 154, 129, 159, 143, 135, 248, 198, 193, 203, 192, 216, 220, 143, 225, 251, 143, 158, 159, 129, 159, 148, 143, 248, 198, 193, 153, 155, 148, 143, 215, 153, 155, 134, 143, 238, 223, 223, 195, 202, 248, 202, 205, 228, 198, 219, 128, 154, 156, 152, 129, 156, 153, 143, 135, 228, 231, 251, 226, 227, 131, 143, 195, 198, 196, 202, 143, 232, 202, 204, 196, 192, 134, 143, 236, 199, 221, 192, 194, 202, 128, 158, 157, 159, 129, 159, 129, 159, 129, 159, 143, 252, 206, 201, 206, 221, 198, 128, 154, 156, 152, 129, 156, 153, 136, 134, 148 }, 175) + _0x893dd4c5._0x4756ee13(new byte[30] { 2, 3, 0, 78, 22, 20, 9, 18, 9, 74, 65, 22, 10, 7, 18, 0, 9, 20, 11, 65, 74, 65, 49, 15, 8, 85, 84, 65, 79, 93 }, 102) + _0x893dd4c5._0x4756ee13(new byte[34] { 66, 67, 64, 14, 86, 84, 73, 82, 73, 10, 1, 80, 67, 72, 66, 73, 84, 1, 10, 1, 97, 73, 73, 65, 74, 67, 6, 111, 72, 69, 8, 1, 15, 29 }, 38) + _0x893dd4c5._0x4756ee13(new byte[30] { 43, 42, 41, 103, 63, 61, 32, 59, 32, 99, 104, 34, 46, 55, 27, 32, 58, 44, 39, 31, 32, 38, 33, 59, 60, 104, 99, 127, 102, 116 }, 79) + _0x893dd4c5._0x4756ee13(new byte[449] { 213, 211, 216, 218, 215, 192, 211, 129, 212, 192, 197, 156, 218, 195, 211, 192, 207, 197, 210, 155, 250, 218, 195, 211, 192, 207, 197, 155, 134, 226, 201, 211, 206, 204, 200, 212, 204, 134, 141, 215, 196, 211, 210, 200, 206, 207, 155, 134, 144, 147, 145, 134, 220, 141, 218, 195, 211, 192, 207, 197, 155, 134, 230, 206, 206, 198, 205, 196, 129, 226, 201, 211, 206, 204, 196, 134, 141, 215, 196, 211, 210, 200, 206, 207, 155, 134, 144, 147, 145, 134, 220, 141, 218, 195, 211, 192, 207, 197, 155, 134, 239, 206, 213, 156, 224, 158, 227, 211, 192, 207, 197, 134, 141, 215, 196, 211, 210, 200, 206, 207, 155, 134, 147, 149, 134, 220, 252, 141, 204, 206, 195, 200, 205, 196, 155, 199, 192, 205, 210, 196, 141, 209, 205, 192, 213, 199, 206, 211, 204, 155, 134, 246, 200, 207, 197, 206, 214, 210, 134, 141, 198, 196, 213, 233, 200, 198, 201, 228, 207, 213, 211, 206, 209, 216, 247, 192, 205, 212, 196, 210, 155, 199, 212, 207, 194, 213, 200, 206, 207, 137, 136, 218, 211, 196, 213, 212, 211, 207, 129, 241, 211, 206, 204, 200, 210, 196, 143, 211, 196, 210, 206, 205, 215, 196, 137, 218, 192, 211, 194, 201, 200, 213, 196, 194, 213, 212, 211, 196, 155, 134, 217, 153, 151, 134, 141, 195, 200, 213, 207, 196, 210, 210, 155, 134, 151, 149, 134, 141, 204, 206, 195, 200, 205, 196, 155, 199, 192, 205, 210, 196, 141, 204, 206, 197, 196, 205, 155, 134, 134, 141, 209, 205, 192, 213, 199, 206, 211, 204, 155, 134, 246, 200, 207, 197, 206, 214, 210, 134, 141, 209, 205, 192, 213, 199, 206, 211, 204, 247, 196, 211, 210, 200, 206, 207, 155, 134, 144, 148, 143, 145, 143, 145, 134, 141, 212, 192, 231, 212, 205, 205, 247, 196, 211, 210, 200, 206, 207, 155, 134, 144, 147, 145, 143, 145, 143, 145, 143, 145, 134, 220, 136, 154, 220, 220, 154, 238, 195, 203, 196, 194, 213, 143, 197, 196, 199, 200, 207, 196, 241, 211, 206, 209, 196, 211, 213, 216, 137, 209, 211, 206, 213, 206, 141, 134, 212, 210, 196, 211, 224, 198, 196, 207, 213, 229, 192, 213, 192, 134, 141, 218, 198, 196, 213, 155, 199, 212, 207, 194, 213, 200, 206, 207, 137, 136, 218, 211, 196, 213, 212, 211, 207, 129, 212, 192, 197, 154, 220, 141, 194, 206, 207, 199, 200, 198, 212, 211, 192, 195, 205, 196, 155, 213, 211, 212, 196, 220, 136, 154, 220, 194, 192, 213, 194, 201, 137, 196, 136, 218, 220 }, 161) + _0x893dd4c5._0x4756ee13(new byte[112] { 180, 181, 182, 248, 163, 179, 162, 181, 181, 190, 252, 247, 167, 185, 180, 164, 184, 247, 252, 225, 233, 226, 224, 249, 235, 180, 181, 182, 248, 163, 179, 162, 181, 181, 190, 252, 247, 184, 181, 185, 183, 184, 164, 247, 252, 225, 224, 232, 224, 249, 235, 180, 181, 182, 248, 163, 179, 162, 181, 181, 190, 252, 247, 177, 166, 177, 185, 188, 135, 185, 180, 164, 184, 247, 252, 225, 233, 226, 224, 249, 235, 180, 181, 182, 248, 163, 179, 162, 181, 181, 190, 252, 247, 177, 166, 177, 185, 188, 152, 181, 185, 183, 184, 164, 247, 252, 225, 224, 228, 224, 249, 235 }, 208) + _0x893dd4c5._0x4756ee13(new byte[45] { 2, 4, 15, 13, 1, 31, 24, 18, 25, 1, 88, 25, 24, 2, 25, 3, 21, 30, 5, 2, 23, 4, 2, 75, 3, 24, 18, 19, 16, 31, 24, 19, 18, 77, 11, 21, 23, 2, 21, 30, 94, 19, 95, 13, 11 }, 118) + _0x893dd4c5._0x4756ee13(new byte[721] { 138, 140, 135, 133, 136, 159, 140, 222, 145, 140, 151, 153, 195, 137, 151, 144, 154, 145, 137, 208, 147, 159, 138, 157, 150, 179, 155, 154, 151, 159, 208, 156, 151, 144, 154, 214, 137, 151, 144, 154, 145, 137, 215, 197, 137, 151, 144, 154, 145, 137, 208, 147, 159, 138, 157, 150, 179, 155, 154, 151, 159, 195, 152, 139, 144, 157, 138, 151, 145, 144, 214, 143, 215, 133, 136, 159, 140, 222, 141, 195, 173, 138, 140, 151, 144, 153, 214, 143, 215, 208, 138, 145, 178, 145, 137, 155, 140, 189, 159, 141, 155, 214, 215, 197, 151, 152, 214, 141, 208, 151, 144, 154, 155, 134, 177, 152, 214, 217, 142, 145, 151, 144, 138, 155, 140, 196, 222, 157, 145, 159, 140, 141, 155, 217, 215, 192, 195, 206, 130, 130, 141, 208, 151, 144, 154, 155, 134, 177, 152, 214, 217, 150, 145, 136, 155, 140, 196, 222, 144, 145, 144, 155, 217, 215, 192, 195, 206, 130, 130, 141, 208, 151, 144, 154, 155, 134, 177, 152, 214, 217, 147, 159, 134, 211, 137, 151, 154, 138, 150, 217, 215, 192, 195, 206, 130, 130, 141, 208, 151, 144, 154, 155, 134, 177, 152, 214, 217, 147, 159, 134, 211, 154, 155, 136, 151, 157, 155, 211, 137, 151, 154, 138, 150, 217, 215, 192, 195, 206, 215, 140, 155, 138, 139, 140, 144, 222, 133, 147, 159, 138, 157, 150, 155, 141, 196, 152, 159, 146, 141, 155, 210, 147, 155, 154, 151, 159, 196, 143, 210, 145, 144, 157, 150, 159, 144, 153, 155, 196, 144, 139, 146, 146, 210, 159, 154, 154, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 140, 155, 147, 145, 136, 155, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 159, 154, 154, 187, 136, 155, 144, 138, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 140, 155, 147, 145, 136, 155, 187, 136, 155, 144, 138, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 154, 151, 141, 142, 159, 138, 157, 150, 187, 136, 155, 144, 138, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 140, 155, 138, 139, 140, 144, 222, 152, 159, 146, 141, 155, 197, 131, 131, 197, 151, 152, 214, 141, 208, 151, 144, 154, 155, 134, 177, 152, 214, 217, 142, 145, 151, 144, 138, 155, 140, 196, 222, 152, 151, 144, 155, 217, 215, 192, 195, 206, 130, 130, 141, 208, 151, 144, 154, 155, 134, 177, 152, 214, 217, 150, 145, 136, 155, 140, 196, 222, 150, 145, 136, 155, 140, 217, 215, 192, 195, 206, 215, 140, 155, 138, 139, 140, 144, 222, 133, 147, 159, 138, 157, 150, 155, 141, 196, 138, 140, 139, 155, 210, 147, 155, 154, 151, 159, 196, 143, 210, 145, 144, 157, 150, 159, 144, 153, 155, 196, 144, 139, 146, 146, 210, 159, 154, 154, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 140, 155, 147, 145, 136, 155, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 159, 154, 154, 187, 136, 155, 144, 138, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 140, 155, 147, 145, 136, 155, 187, 136, 155, 144, 138, 178, 151, 141, 138, 155, 144, 155, 140, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 131, 210, 154, 151, 141, 142, 159, 138, 157, 150, 187, 136, 155, 144, 138, 196, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133, 140, 155, 138, 139, 140, 144, 222, 152, 159, 146, 141, 155, 197, 131, 131, 197, 140, 155, 138, 139, 140, 144, 222, 145, 140, 151, 153, 214, 143, 215, 197, 131, 197, 131, 157, 159, 138, 157, 150, 214, 155, 215, 133, 131 }, 254) + _0x893dd4c5._0x4756ee13(new byte[5] { 157, 201, 200, 201, 219 }, 224);
    }

    private string _0xc89594a2()
    {
        try
        {
            using (var _0xb0d4339c = new AndroidJavaClass(_0x893dd4c5._0x4756ee13(new byte[30] { 167, 171, 169, 234, 177, 170, 173, 176, 189, 247, 160, 234, 180, 168, 165, 189, 161, 182, 234, 145, 170, 173, 176, 189, 148, 168, 165, 189, 161, 182 }, 196)))
            {
                var _0xc21c1d02 = _0xb0d4339c.GetStatic<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[15] { 205, 219, 220, 220, 203, 192, 218, 239, 205, 218, 199, 216, 199, 218, 215 }, 174));
                var _0xa562357d = _0xc21c1d02.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[21] { 57, 59, 42, 31, 46, 46, 50, 55, 61, 63, 42, 55, 49, 48, 29, 49, 48, 42, 59, 38, 42 }, 94));
                using (var _0x2bdda0fe = new AndroidJavaClass(_0x893dd4c5._0x4756ee13(new byte[26] { 227, 236, 230, 240, 237, 235, 230, 172, 245, 231, 224, 233, 235, 246, 172, 213, 231, 224, 209, 231, 246, 246, 235, 236, 229, 241 }, 130)))
                {
                    return _0x2bdda0fe.CallStatic<string>(_0x893dd4c5._0x4756ee13(new byte[19] { 135, 133, 148, 164, 133, 134, 129, 149, 140, 148, 181, 147, 133, 146, 161, 135, 133, 142, 148 }, 224), _0xa562357d);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private static string ReadPushField(Dictionary<string, object> _0x5f295cc3, string _0x896e2cff)
    {
        if (_0x5f295cc3 == null || string.IsNullOrEmpty(_0x896e2cff))
            return string.Empty;
        if (_0x5f295cc3.TryGetValue(_0x893dd4c5._0x4756ee13(new byte[16] { 184, 185, 162, 191, 176, 191, 181, 183, 162, 191, 185, 184, 146, 183, 162, 183 }, 214), out var raw))
        {
            try
            {
                var _0xf3158a17 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0xf3158a17 != null && _0xf3158a17.TryGetValue(_0x896e2cff, out var nestedVal))
                {
                    var _0x8c04c2d8 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x8c04c2d8))
                        return _0x8c04c2d8;
                }
            }
            catch
            {
            }
        }

        if (_0x5f295cc3.TryGetValue(_0x896e2cff, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    // WEB VIEW LOGIC END
    internal void _0x21362046()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xb1bfd9d5 = new AndroidNotificationChannel
        {
            Id = _0x893dd4c5._0x4756ee13(new byte[15] { 136, 137, 138, 141, 153, 128, 152, 179, 143, 132, 141, 130, 130, 137, 128 }, 236),
            Name = _0x893dd4c5._0x4756ee13(new byte[15] { 194, 227, 224, 231, 243, 234, 242, 166, 197, 238, 231, 232, 232, 227, 234 }, 134),
            Importance = Importance.High,
            Description = _0x893dd4c5._0x4756ee13(new byte[21] { 100, 70, 77, 70, 81, 66, 79, 3, 77, 76, 87, 74, 69, 74, 64, 66, 87, 74, 76, 77, 80 }, 35)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xb1bfd9d5);
        // Build notification
        var _0xf215ea8a = new AndroidNotification
        {
            Title = _0x589ae2b9[UnityEngine.Random.Range(0, _0x589ae2b9.Length)],
            Text = _0x893dd4c5._0x4756ee13(new byte[21] { 186, 137, 158, 219, 130, 148, 142, 219, 136, 142, 137, 158, 219, 143, 148, 219, 158, 131, 146, 143, 196 }, 251),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xf215ea8a, _0x893dd4c5._0x4756ee13(new byte[15] { 223, 222, 221, 218, 206, 215, 207, 228, 216, 211, 218, 213, 213, 222, 215 }, 187));
    }

    private bool _0x3a697159 = false;
    private void _0x9a4ce814()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private bool _0x82eb0fca(string _0x2fe19d57)
    {
        try
        {
            using (var _0x80be99a9 = new AndroidJavaClass(_0x893dd4c5._0x4756ee13(new byte[30] { 109, 97, 99, 32, 123, 96, 103, 122, 119, 61, 106, 32, 126, 98, 111, 119, 107, 124, 32, 91, 96, 103, 122, 119, 94, 98, 111, 119, 107, 124 }, 14)))
            using (var _0x696fbf3e = _0x80be99a9.GetStatic<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[15] { 53, 35, 36, 36, 51, 56, 34, 23, 53, 34, 63, 32, 63, 34, 47 }, 86)))
            using (var _0xa238e6fd = _0x696fbf3e.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[17] { 247, 245, 228, 192, 241, 243, 251, 241, 247, 245, 221, 241, 254, 241, 247, 245, 226 }, 144)))
            using (var _0xefac9f29 = new AndroidJavaClass(_0x893dd4c5._0x4756ee13(new byte[22] { 54, 57, 51, 37, 56, 62, 51, 121, 52, 56, 57, 35, 50, 57, 35, 121, 30, 57, 35, 50, 57, 35 }, 87)))
            using (var _0xa6afb3f8 = _0xefac9f29.CallStatic<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[8] { 108, 125, 110, 111, 121, 73, 110, 117 }, 28), _0x2fe19d57, 1))
            {
                string _0x2dd0369c = _0xa6afb3f8.Call<string>(_0x893dd4c5._0x4756ee13(new byte[14] { 44, 46, 63, 24, 63, 57, 34, 37, 44, 14, 51, 63, 57, 42 }, 75), _0x893dd4c5._0x4756ee13(new byte[20] { 148, 132, 153, 129, 133, 147, 132, 169, 144, 151, 154, 154, 148, 151, 149, 157, 169, 131, 132, 154 }, 246));
                string _0x6a11574b = _0xa6afb3f8.Call<string>(_0x893dd4c5._0x4756ee13(new byte[10] { 160, 162, 179, 151, 166, 164, 172, 166, 160, 162 }, 199));
                _0xa6afb3f8.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[11] { 133, 128, 128, 167, 133, 144, 129, 131, 139, 150, 157 }, 228), _0x893dd4c5._0x4756ee13(new byte[33] { 111, 96, 106, 124, 97, 103, 106, 32, 103, 96, 122, 107, 96, 122, 32, 109, 111, 122, 107, 105, 97, 124, 119, 32, 76, 92, 65, 89, 93, 79, 76, 66, 75 }, 14));
                _0xa6afb3f8.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[11] { 143, 152, 144, 146, 139, 152, 184, 133, 137, 143, 156 }, 253), _0x893dd4c5._0x4756ee13(new byte[20] { 128, 144, 141, 149, 145, 135, 144, 189, 132, 131, 142, 142, 128, 131, 129, 137, 189, 151, 144, 142 }, 226));
                if (_0xa6afb3f8.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[15] { 91, 76, 90, 70, 69, 95, 76, 104, 74, 93, 64, 95, 64, 93, 80 }, 41), _0xa238e6fd) != null)
                {
                    WLog(_0x893dd4c5._0x4756ee13(new byte[24] { 99, 72, 82, 79, 77, 69, 108, 73, 75, 69, 0, 79, 80, 69, 78, 0, 73, 78, 84, 69, 78, 84, 26, 0 }, 32) + _0x2fe19d57);
                    _0xa6afb3f8.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[8] { 165, 160, 160, 130, 168, 165, 163, 183 }, 196), 0x10000000);
                    _0x696fbf3e.Call(_0x893dd4c5._0x4756ee13(new byte[13] { 175, 168, 189, 174, 168, 157, 191, 168, 181, 170, 181, 168, 165 }, 220), _0xa6afb3f8);
                    return true;
                }

                if (_0xd7a61572(_0x6a11574b))
                    return true;
                if (!string.IsNullOrEmpty(_0x2dd0369c))
                {
                    WLog(_0x893dd4c5._0x4756ee13(new byte[28] { 122, 81, 75, 86, 84, 92, 117, 80, 82, 92, 25, 80, 87, 77, 92, 87, 77, 25, 95, 88, 85, 85, 91, 88, 90, 82, 3, 25 }, 57) + _0x2dd0369c);
                    if (_0xcba90471(_0x2dd0369c))
                        return _0xb6a48890(_0x2dd0369c, _0x6a11574b);
                    return _0xfbe909cd(_0x2dd0369c);
                }

                WLog(_0x893dd4c5._0x4756ee13(new byte[30] { 124, 87, 77, 80, 82, 90, 115, 86, 84, 90, 31, 86, 81, 75, 90, 81, 75, 31, 81, 80, 31, 87, 94, 81, 91, 83, 90, 77, 5, 31 }, 63) + _0x2fe19d57);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x893dd4c5._0x4756ee13(new byte[26] { 28, 55, 45, 48, 50, 58, 19, 54, 52, 58, 127, 54, 49, 43, 58, 49, 43, 127, 57, 62, 54, 51, 58, 59, 101, 127 }, 95) + e.Message);
            return true;
        }
    }

    private bool OpenUrlExternally(string _0x4ff21e72)
    {
        return _0xfbe909cd(_0x4ff21e72);
    }

    private string _0x2595db6b = "";
    private bool _0xd7a61572(string _0x89ea143c)
    {
        if (string.IsNullOrEmpty(_0x89ea143c))
            return false;
        try
        {
            using (var _0xb3da292f = new AndroidJavaClass(_0x893dd4c5._0x4756ee13(new byte[30] { 29, 17, 19, 80, 11, 16, 23, 10, 7, 77, 26, 80, 14, 18, 31, 7, 27, 12, 80, 43, 16, 23, 10, 7, 46, 18, 31, 7, 27, 12 }, 126)))
            using (var _0x2cb09782 = _0xb3da292f.GetStatic<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[15] { 71, 81, 86, 86, 65, 74, 80, 101, 71, 80, 77, 82, 77, 80, 93 }, 36)))
            using (var _0x45447884 = _0x2cb09782.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[17] { 29, 31, 14, 42, 27, 25, 17, 27, 29, 31, 55, 27, 20, 27, 29, 31, 8 }, 122)))
            using (var _0xa7b97e51 = _0x45447884.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[25] { 137, 139, 154, 162, 143, 155, 128, 141, 134, 167, 128, 154, 139, 128, 154, 168, 129, 156, 190, 143, 141, 133, 143, 137, 139 }, 238), _0x89ea143c))
            {
                if (_0xa7b97e51 == null)
                    return false;
                WLog(_0x893dd4c5._0x4756ee13(new byte[37] { 215, 252, 230, 251, 249, 241, 216, 253, 255, 241, 180, 248, 245, 225, 250, 247, 252, 180, 253, 250, 231, 224, 245, 248, 248, 241, 240, 180, 228, 245, 247, 255, 245, 243, 241, 174, 180 }, 148) + _0x89ea143c);
                _0xa7b97e51.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[8] { 69, 64, 64, 98, 72, 69, 67, 87 }, 36), 0x10000000);
                _0x2cb09782.Call(_0x893dd4c5._0x4756ee13(new byte[13] { 93, 90, 79, 92, 90, 111, 77, 90, 71, 88, 71, 90, 87 }, 46), _0xa7b97e51);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private Text _0x8f1e0a96;
    private ApplicationInstallMode _0xcf57450b = ApplicationInstallMode.Unknown;
    private async Task<bool> _0xd728256d()
    {
        _0x0c0418a5.Instance?._0x109efdcd();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x2b7ef7ad) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x893dd4c5._0x4756ee13(new byte[32] { 58, 53, 4, 18, 21, 60, 65, 52, 15, 8, 21, 24, 65, 49, 20, 18, 9, 65, 47, 14, 21, 8, 7, 8, 2, 0, 21, 8, 14, 15, 91, 65 }, 97) + string.Join(_0x893dd4c5._0x4756ee13(new byte[1] { 187 }, 178), _0x2b7ef7ad));
                }
#endif
            }
        };
        try
        {
            _0xfa56fcf5 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x893dd4c5._0x4756ee13(new byte[31] { 150, 153, 168, 190, 185, 144, 237, 139, 172, 164, 161, 168, 169, 237, 185, 162, 237, 170, 168, 185, 237, 189, 184, 190, 165, 237, 185, 162, 166, 168, 163 }, 205));
                }
#endif
            }

            _0xfa56fcf5 = "";
        }

        _0xcf76a27d = !string.IsNullOrEmpty(_0xfa56fcf5);
        _0x6824fd07 = _0xb60ff212();
        {
#if B_LOGS
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[25] { 95, 80, 97, 119, 112, 89, 36, 81, 106, 109, 112, 125, 36, 84, 113, 119, 108, 36, 80, 107, 111, 97, 106, 62, 36 }, 4) + _0xfa56fcf5);
#endif
        }

        _0x0c0418a5.Instance?._0x1b301219();
        return false;
    }

    private AndroidJavaObject _0x770d16f1 { get; set; }

    private void _0x3c88b493(string _0xcde48e5d)
    {
        Dictionary<string, object> _0x538975d6;
        try
        {
            _0x538975d6 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xcde48e5d);
        }
        catch
        {
            return;
        }

        var _0x2110dd07 = ReadPushField(_0x538975d6, _0x893dd4c5._0x4756ee13(new byte[3] { 59, 60, 34 }, 78));
        if (string.IsNullOrWhiteSpace(_0x2110dd07))
            return;
        _0x2110dd07 = _0x2110dd07.Trim();
        if (!IsHttpUrl(_0x2110dd07))
            return;
        if (string.Equals(_0x2110dd07, _0xac55f0b9, StringComparison.Ordinal))
            return;
        _0xac55f0b9 = _0x2110dd07;
        OpenUrlExternally(_0x2110dd07);
    }

    private static bool IsPrivacyItemTrue(Item _0x96d9f4c9)
    {
        if (_0x96d9f4c9.Key != _0x893dd4c5._0x4756ee13(new byte[9] { 197, 223, 252, 222, 197, 218, 205, 207, 213 }, 172))
            return false;
        try
        {
            var _0x8a50ec9e = _0x96d9f4c9.Value.GetAs<object>();
            return _0x8a50ec9e switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private IEnumerator _0x7f5bc542(float _0xecd807f6)
    {
        yield return new WaitForSeconds(_0xecd807f6);
        if (!_0x33c016db)
        {
            _0x33c016db = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x919b307f}");
                }
#endif
            }
        }
    }

    private async Task _0x52362825()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x3330b35e = _0x893dd4c5._0x4756ee13(new byte[5] { 88, 95, 82, 77, 91 }, 62);
        _0x2e942bcf = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x2595db6b = DateTime.UtcNow.Ticks.ToString();
        _0x41ab7911 = "";
        JObject _0xb90b372d = _0xf38719ef(_0x8fe1c5a0, _0xf52749fc, _0xc67ac6be, _0xfa56fcf5, _0x919b307f, _0x3d81885d, _0xb0faec9f, _0x1b35e579, _0x21e9d7dc, _0xa0191fe8, _0x3330b35e, _0x41ab7911, _0x9b1daa43, _0xb5878e79, _0xcf57450b.ToString(), _0x3c61d372, _0x2595db6b, _0x2e942bcf, _0xf9b182fa, _0x75b655c2, _0xa5f4d7b0, _0x6824fd07, _0xb60ff212());
        var _0x83e67f79 = _0x95995d80(_0xb90b372d.ToString(), _0xf9b182fa);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xb90b372d}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x893dd4c5._0x4756ee13(new byte[7] { 54, 39, 63, 42, 41, 39, 34 }, 70) + _0xf9b182fa, _0x83e67f79 } });
            await Task.Delay(500);
            string _0x71d1c81c = "";
            for (int _0x5161a1cb = 0; _0x5161a1cb < 20; _0x5161a1cb++)
            {
                if (await _0xee3332f1(1, 1))
                {
                    await _0xe280eb0a(_0x893dd4c5._0x4756ee13(new byte[7] { 179, 189, 190, 178, 186, 180, 181 }, 209));
                    _0xa8b5b03d();
                    return;
                }

                _0x71d1c81c = await _0x0c0b04cd(1, 500);
                if (!string.IsNullOrEmpty(_0x71d1c81c))
                    break;
            }

            _0x1c2d1156(_0x71d1c81c);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[22] { 2, 13, 28, 10, 13, 4, 121, 30, 60, 55, 60, 43, 56, 53, 121, 60, 43, 43, 54, 43, 99, 121 }, 89) + e.Message);
#endif
            }

            _0xa8b5b03d();
        }
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x21d4b057()
    {
        var _0x9b5dd12c = _0x893dd4c5._0x4756ee13(new byte[40] { 189, 161, 161, 165, 166, 239, 250, 250, 162, 162, 162, 251, 182, 185, 186, 160, 177, 179, 185, 180, 167, 176, 251, 182, 186, 184, 250, 182, 177, 187, 248, 182, 178, 188, 250, 161, 167, 180, 182, 176 }, 213);
        using (UnityWebRequest _0x6d0ce60b = UnityWebRequest.Get(_0x9b5dd12c))
        {
            await _0x6d0ce60b.SendWebRequest();
            string[] _0x9ec4f942 = _0x6d0ce60b.downloadHandler.text.Split('\n');
            foreach (string _0x23dbb945 in _0x9ec4f942)
            {
                if (_0x23dbb945.StartsWith(_0x893dd4c5._0x4756ee13(new byte[3] { 164, 189, 240 }, 205)))
                {
                    string _0x6d0cd907 = _0x23dbb945.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x6d0cd907} from {_0x9b5dd12c}");
                        }
#endif
                    }

                    return _0x6d0cd907;
                }
            }
        }

        return "";
    }

    private bool _0x57aff127 = false;
    private bool _0x20ed2072 = false;
    private void _0x0cc4c1b8()
    {
        if (_0x98b89ec5 != null)
            return;
        var _0x0383171f = _0x3e50b7b2();
        _0x98b89ec5 = new GameObject(_0x893dd4c5._0x4756ee13(new byte[14] { 99, 81, 86, 98, 93, 81, 67, 103, 68, 93, 90, 90, 81, 70 }, 52), typeof(RectTransform), typeof(Text));
        _0x2a25f1e0 = _0x98b89ec5.GetComponent<RectTransform>();
        _0x2a25f1e0.SetParent(_0x0383171f.transform, false);
        _0x2a25f1e0.anchorMin = new Vector2(0.5f, 0.5f);
        _0x2a25f1e0.anchorMax = new Vector2(0.5f, 0.5f);
        _0x2a25f1e0.pivot = new Vector2(0.5f, 0.5f);
        _0x2a25f1e0.sizeDelta = new Vector2(600f, 600f);
        _0x2a25f1e0.anchoredPosition = Vector2.zero;
        _0x8f1e0a96 = _0x98b89ec5.GetComponent<Text>();
        _0x8f1e0a96.text = _0x893dd4c5._0x4756ee13(new byte[1] { 121 }, 86);
        _0x8f1e0a96.font = Resources.GetBuiltinResource<Font>(_0x893dd4c5._0x4756ee13(new byte[17] { 149, 188, 190, 184, 186, 160, 139, 172, 183, 173, 176, 180, 188, 247, 173, 173, 191 }, 217));
        _0x8f1e0a96.fontSize = 200;
        _0x8f1e0a96.alignment = TextAnchor.MiddleCenter;
        _0x8f1e0a96.color = Color.white;
        _0x8f1e0a96.raycastTarget = false;
        _0x98b89ec5.SetActive(false);
    }

    private GameObject _0x98b89ec5;
    private bool TryOpenExternalLikeChrome(string _0x40a058fe)
    {
        if (string.IsNullOrEmpty(_0x40a058fe))
            return false;
        if (_0x40a058fe.StartsWith(_0x893dd4c5._0x4756ee13(new byte[9] { 199, 192, 218, 203, 192, 218, 148, 129, 129 }, 174), StringComparison.OrdinalIgnoreCase))
            return _0x82eb0fca(_0x40a058fe);
        if (_0xcba90471(_0x40a058fe))
            return _0xb6a48890(_0x40a058fe, null);
        if (!_0x40a058fe.StartsWith(_0x893dd4c5._0x4756ee13(new byte[7] { 115, 111, 111, 107, 33, 52, 52 }, 27), StringComparison.OrdinalIgnoreCase) && !_0x40a058fe.StartsWith(_0x893dd4c5._0x4756ee13(new byte[8] { 186, 166, 166, 162, 161, 232, 253, 253 }, 210), StringComparison.OrdinalIgnoreCase) && !_0x40a058fe.StartsWith(_0x893dd4c5._0x4756ee13(new byte[11] { 167, 164, 169, 179, 178, 252, 164, 170, 167, 168, 173 }, 198), StringComparison.OrdinalIgnoreCase))
        {
            return _0xfbe909cd(_0x40a058fe);
        }

        return false;
    }

    private string _0x2e942bcf = "";
    private string _0x3c61d372 = "";
    private string _0x6786aea7(string _0x4e80e740, string _0x44a702f7)
    {
        if (string.IsNullOrEmpty(_0x44a702f7))
            return _0x4e80e740;
        if (_0x4e80e740.Contains(_0x893dd4c5._0x4756ee13(new byte[1] { 245 }, 202)))
            return _0x4e80e740 + _0x893dd4c5._0x4756ee13(new byte[8] { 19, 70, 80, 91, 81, 92, 81, 8 }, 53) + UnityWebRequest.EscapeURL(_0x44a702f7);
        else
            return _0x4e80e740 + _0x893dd4c5._0x4756ee13(new byte[8] { 93, 17, 7, 12, 6, 11, 6, 95 }, 98) + UnityWebRequest.EscapeURL(_0x44a702f7);
    }

    private string _0x3d81885d { get; set; }

    private string _0xf52749fc = "";
    internal bool isApplicationFocus = false;
    private string _0x8fe1c5a0 = "";
    private JObject _0xf38719ef(params string[] _0x174f2069)
    {
        JObject _0x54938f99 = new JObject();
        foreach (var _0xdf880ec3 in _0x174f2069)
        {
            string _0xe46cf73c = _0x417303d5();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xe46cf73c} val={_0xdf880ec3}");
#endif
            }

            _0x54938f99.Add(_0xe46cf73c, _0xdf880ec3 == null ? "" : _0xdf880ec3);
        }

        return _0x54938f99;
    }

    private IEnumerator _0xc64993e6()
    {
        yield return _0x22a87537(Permission.Camera);
    }

    private void _0x6c10b6f2()
    {
        {
#if B_LOGS
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[22] { 71, 72, 121, 111, 104, 65, 60, 79, 104, 115, 110, 121, 88, 121, 106, 117, 127, 121, 85, 114, 122, 115 }, 28));
#endif
        }

        _0x9b1daa43 = SystemInfo.deviceModel;
        _0xb5878e79 = Application.version;
        _0xcf57450b = Application.installMode;
        _0x3c61d372 = Application.installerName;
        _0x8fe1c5a0 = Application.identifier;
        _0xc67ac6be = _0x6948b5ac();
        _0x1b35e579 = _0xc89594a2();
        _0xa0191fe8 = SystemInfo.deviceUniqueIdentifier;
        _0x75b655c2 = SystemInfo.graphicsDeviceName;
        _0xa5f4d7b0 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0xb5878e79 = _0x893dd4c5._0x4756ee13(new byte[5] { 207, 214, 207, 214, 207 }, 248);
                _0xcf57450b = ApplicationInstallMode.Store;
                _0x3c61d372 = _0x893dd4c5._0x4756ee13(new byte[19] { 215, 219, 217, 154, 213, 218, 208, 198, 219, 221, 208, 154, 194, 209, 218, 208, 221, 218, 211 }, 180);
                _0x1b35e579 = _0x893dd4c5._0x4756ee13(new byte[8] { 34, 42, 55, 51, 62, 103, 50, 38 }, 71);
                _0xa0191fe8 = Guid.NewGuid().ToString().Replace(_0x893dd4c5._0x4756ee13(new byte[1] { 238 }, 195), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[17] { 38, 41, 24, 14, 9, 32, 93, 25, 24, 11, 48, 18, 25, 24, 17, 71, 93 }, 125) + _0x9b1daa43);
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[19] { 204, 195, 242, 228, 227, 202, 183, 246, 231, 231, 193, 242, 229, 228, 254, 248, 249, 173, 183 }, 151) + _0xb5878e79);
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[20] { 201, 198, 247, 225, 230, 207, 178, 251, 252, 225, 230, 243, 254, 254, 223, 253, 246, 247, 168, 178 }, 146) + _0xcf57450b);
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[23] { 61, 50, 3, 21, 18, 59, 70, 15, 8, 21, 18, 7, 10, 10, 3, 20, 53, 18, 9, 20, 3, 92, 70 }, 102) + _0x3c61d372);
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[14] { 161, 174, 159, 137, 142, 167, 218, 155, 138, 138, 179, 158, 192, 218 }, 250) + _0x8fe1c5a0);
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[14] { 111, 96, 81, 71, 64, 105, 20, 85, 80, 66, 125, 80, 14, 20 }, 52) + _0xc67ac6be);
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[18] { 183, 184, 137, 159, 152, 177, 204, 153, 159, 137, 158, 173, 139, 137, 130, 152, 214, 204 }, 236) + _0x1b35e579);
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[17] { 179, 188, 141, 155, 156, 181, 200, 155, 145, 155, 172, 141, 158, 161, 140, 210, 200 }, 232) + _0xa0191fe8);
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[12] { 31, 16, 33, 55, 48, 25, 100, 35, 52, 49, 126, 100 }, 68) + _0x75b655c2);
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[12] { 163, 172, 157, 139, 140, 165, 216, 155, 136, 141, 194, 216 }, 248) + _0xa5f4d7b0);
#endif
        }
    }

    internal void _0x11745bf5()
    {
        Rect _0x7e092517 = Screen.safeArea;
        Vector2 _0xfe6369ca = new Vector2(Screen.width, Screen.height);
        if (_0x7e092517 == lastSafe && _0xfe6369ca == lastSize)
            return;
        // Apply manual padding
        _0x7e092517.xMin += _0x58c2b77b;
        _0x7e092517.xMax -= _0x57636163;
        _0x7e092517.yMin += _0xa4a6c66d;
        _0x7e092517.yMax -= _0x7f19bfa4;
        // Convert Unity safe area -> native WebView frame
        Rect _0x7e571865 = new Rect(_0x7e092517.x, _0xfe6369ca.y - _0x7e092517.y - _0x7e092517.height, // Y flip for native coordinate system
 _0x7e092517.width, _0x7e092517.height);
        _0x5f57ded1.Frame = _0x7e571865;
        lastSafe = Screen.safeArea;
        lastSize = _0xfe6369ca;
    }

    // WEB VIEW LOGIC
    public bool _0xfceb9fa1 { get; set; }

    private bool _0xc1b879a6()
    {
        var _0xbd9cc4c9 = _0x7eafae23();
        if (_0xbd9cc4c9 == null)
            return false;
        WLog(_0x893dd4c5._0x4756ee13(new byte[31] { 169, 128, 147, 133, 150, 128, 147, 132, 193, 131, 128, 130, 138, 193, 204, 223, 193, 145, 142, 145, 148, 145, 193, 166, 142, 163, 128, 130, 138, 219, 193 }, 225) + _0xbd9cc4c9.Id);
        _0xbd9cc4c9.GoBack();
        return true;
    }

    internal void Update()
    {
        if (_0x5f57ded1 == null)
            return;
        if (_0xa5bea9c2())
            _0x32db6a05();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x11745bf5();
        if (_0x51b14c75 && _0x2a25f1e0 != null)
            _0x2a25f1e0.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private bool _0x51b14c75 = false;
    private string _0x9b1daa43 = "";
    private void _0x80834522(string _0x1da89ae0)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[34] { 228, 235, 218, 204, 203, 226, 159, 249, 218, 203, 220, 215, 159, 250, 199, 203, 205, 222, 159, 239, 202, 204, 215, 159, 251, 222, 203, 222, 159, 237, 222, 200, 133, 159 }, 191) + _0x1da89ae0);
#endif
            }
        }

        var _0xbca46484 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x1da89ae0);
        StartCoroutine(_0x75b3611f(_0xbca46484));
    }

    internal bool isApplicationPause = false;
    private IEnumerator _0xf5c9ffa5()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[26] { 10, 5, 52, 34, 37, 12, 113, 24, 63, 56, 37, 56, 48, 61, 56, 43, 52, 3, 52, 55, 55, 52, 35, 52, 35, 113 }, 81));
            }
#endif
        }

        bool _0xd9940c28 = false;
        InstallReferrer.GetReferrer((_0xe4ba166a) =>
        {
            Debug.Log(_0x893dd4c5._0x4756ee13(new byte[24] { 254, 241, 192, 214, 209, 133, 247, 192, 195, 192, 215, 215, 192, 215, 248, 133, 194, 192, 209, 133, 71, 35, 55, 133 }, 165) + _0x919b307f);
            if (_0xe4ba166a.IsSuccess)
            {
                _0x919b307f = _0xe4ba166a.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x893dd4c5._0x4756ee13(new byte[28] { 185, 182, 135, 145, 150, 194, 176, 135, 132, 135, 144, 144, 135, 144, 191, 194, 177, 151, 129, 129, 135, 145, 145, 194, 0, 100, 112, 194 }, 226) + _0x919b307f);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x893dd4c5._0x4756ee13(new byte[27] { 21, 26, 43, 61, 58, 110, 28, 43, 40, 43, 60, 60, 43, 60, 19, 110, 8, 47, 39, 34, 43, 42, 110, 172, 200, 220, 110 }, 78) + _0xe4ba166a);
#endif
                }

                _0x919b307f = "";
            }

            _0x33c016db = true;
        });
        StartCoroutine(_0x7f5bc542(2f));
        yield return new WaitUntil(() => _0x33c016db);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x919b307f}");
#endif
        }

        bool _0x4c780a08 = _0x919b307f.Contains(_0x893dd4c5._0x4756ee13(new byte[6] { 12, 8, 7, 2, 15, 86 }, 107));
        _0xd9940c28 = _0x4c780a08 || _0x919b307f.Contains(_0x893dd4c5._0x4756ee13(new byte[18] { 105, 120, 120, 123, 38, 97, 102, 123, 124, 105, 111, 122, 105, 101, 38, 107, 103, 101 }, 8)) || _0x919b307f.Contains(_0x893dd4c5._0x4756ee13(new byte[17] { 11, 26, 26, 25, 68, 12, 11, 9, 15, 8, 5, 5, 1, 68, 9, 5, 7 }, 106));
        _0x3d81885d = _0x4c780a08 ? "" : (_0xd9940c28 ? "" : _0x3d81885d);
        _0x3d81885d = _0x3d81885d ?? "";
        _0xb0faec9f = _0xb0faec9f ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x3d81885d}");
#endif
        }
    }

    private void _0x265b4be7()
    {
        if (_0x3a697159)
        {
            WLog(_0x893dd4c5._0x4756ee13(new byte[18] { 73, 116, 101, 120, 44, 109, 96, 126, 105, 109, 104, 117, 44, 127, 100, 99, 123, 98 }, 12));
            return;
        }

        _0xa4f9701d(false);
        WLog(_0x893dd4c5._0x4756ee13(new byte[46] { 68, 104, 96, 103, 41, 94, 108, 107, 95, 96, 108, 126, 41, 89, 124, 122, 97, 41, 71, 102, 125, 96, 111, 96, 106, 104, 125, 96, 102, 103, 41, 33, 97, 104, 123, 109, 126, 104, 123, 108, 41, 107, 104, 106, 98, 32 }, 9));
        ++_0x21cfa60a;
        _0x21362046();
        if (_0x21cfa60a <= 1)
            return;
        if (_0x5509ee3f())
        {
            WLog(_0x893dd4c5._0x4756ee13(new byte[37] { 225, 220, 205, 208, 132, 215, 207, 205, 212, 212, 193, 192, 132, 137, 154, 132, 212, 203, 212, 209, 212, 215, 132, 215, 208, 205, 200, 200, 132, 203, 212, 193, 202, 193, 192, 158, 132 }, 164) + _0xe57a15f9.Count);
            return;
        }

        Application.Quit();
    }

    private string _0xf9b182fa = "";
    private Canvas _0x3e50b7b2()
    {
        if (_0xb0c6f995 != null)
            return _0xb0c6f995;
        var _0xd761f2e8 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xd761f2e8 == null)
        {
            var _0x140d5397 = new GameObject(_0x893dd4c5._0x4756ee13(new byte[6] { 54, 20, 27, 3, 20, 6 }, 117), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xd761f2e8 = _0x140d5397.GetComponent<Canvas>();
            _0xd761f2e8.transform.SetParent(transform, false);
            _0xd761f2e8.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xb0c6f995 = _0xd761f2e8;
        return _0xb0c6f995;
    }

    private async Task<bool> _0xee3332f1(int _0xfa6e69cb = 5, int _0x30455df2 = 500)
    {
        List<EntityData> _0x8cde2bfe = new List<EntityData>();
        int _0x3a1e28f5 = 0;
        do
        {
            try
            {
                _0x8cde2bfe = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x893dd4c5._0x4756ee13(new byte[8] { 16, 12, 1, 25, 5, 18, 41, 4 }, 96), _0xf9b182fa, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x893dd4c5._0x4756ee13(new byte[9] { 116, 110, 77, 111, 116, 107, 124, 126, 100 }, 29) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x893dd4c5._0x4756ee13(new byte[32] { 150, 153, 168, 190, 185, 144, 237, 188, 184, 168, 191, 180, 140, 190, 180, 163, 174, 159, 168, 190, 184, 161, 185, 190, 237, 168, 191, 191, 162, 191, 247, 237 }, 205) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x30455df2);
        }
        while (_0x8cde2bfe.Count == 0 && _0x3a1e28f5++ < _0xfa6e69cb);
        {
#if B_LOGS
            {
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[32] { 2, 13, 60, 42, 45, 4, 121, 16, 42, 9, 43, 48, 47, 56, 58, 32, 121, 8, 44, 60, 43, 32, 121, 43, 60, 42, 44, 53, 45, 42, 99, 121 }, 89) + JsonConvert.SerializeObject(_0x8cde2bfe, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[38] { 163, 172, 157, 139, 140, 165, 216, 177, 139, 168, 138, 145, 142, 153, 155, 129, 216, 169, 141, 157, 138, 129, 216, 138, 157, 139, 141, 148, 140, 139, 216, 155, 151, 141, 150, 140, 194, 216 }, 248) + _0x8cde2bfe.Count);
            }
#endif
        }

        bool _0xd45193e4 = true;
        if (_0x8cde2bfe.Count == 0)
        {
            _0xd45193e4 = false;
        }
        else
        {
            _0xd45193e4 = _0x8cde2bfe.Any(_0x62c93a74 => _0x62c93a74.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[25] { 166, 169, 152, 142, 137, 160, 221, 180, 142, 173, 143, 148, 139, 156, 158, 132, 221, 143, 152, 142, 136, 145, 137, 199, 221 }, 253) + _0xd45193e4);
            }
#endif
        }

        return _0xd45193e4;
    }

    private static readonly string WindowsDesktopUserAgent = _0x893dd4c5._0x4756ee13(new byte[111] { 219, 249, 236, 255, 250, 250, 247, 185, 163, 184, 166, 182, 190, 193, 255, 248, 242, 249, 225, 229, 182, 216, 194, 182, 167, 166, 184, 166, 173, 182, 193, 255, 248, 160, 162, 173, 182, 238, 160, 162, 191, 182, 215, 230, 230, 250, 243, 193, 243, 244, 221, 255, 226, 185, 163, 165, 161, 184, 165, 160, 182, 190, 221, 222, 194, 219, 218, 186, 182, 250, 255, 253, 243, 182, 209, 243, 245, 253, 249, 191, 182, 213, 254, 228, 249, 251, 243, 185, 167, 164, 166, 184, 166, 184, 166, 184, 166, 182, 197, 247, 240, 247, 228, 255, 185, 163, 165, 161, 184, 165, 160 }, 150);
    private RectTransform _0x2a25f1e0;
    // MAIN FLOW
    private bool _0x33c016db { get; set; }

    private void Awake()
    {
        if (_0x048cc6fe != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x048cc6fe = gameObject.GetComponent<_0x049ebdfd>();
        DontDestroyOnLoad(gameObject);
        _0xfa56fcf5 = _0x3d81885d = _0xb0faec9f = "";
        _0x2187d8f0 = "";
        _0xfceb9fa1 = false;
    }

    private void StopCurrentFailedLoad(UniWebView _0xd5495c6d)
    {
        _0xa4f9701d(false);
        if (_0xd5495c6d == null)
            return;
        _0xd5495c6d.Stop();
        if (_0xd5495c6d.CanGoBack)
            _0xd5495c6d.GoBack();
    }

    private async Task _0x0522357a()
    {
        if (await _0x867c7f46())
            return;
        if (await _0xd728256d())
            return;
        if (await _0xfb128f71())
            return;
        _0x6c10b6f2();
        await _0x9d993665(_0xf5c9ffa5());
        _0x21e9d7dc = await _0x21d4b057();
        await _0x52362825();
    }

    private void _0x931633c6()
    {
        using (var _0x3f212a19 = new AndroidJavaClass(_0x893dd4c5._0x4756ee13(new byte[30] { 183, 187, 185, 250, 161, 186, 189, 160, 173, 231, 176, 250, 164, 184, 181, 173, 177, 166, 250, 129, 186, 189, 160, 173, 132, 184, 181, 173, 177, 166 }, 212)))
        using (var _0x99e1771a = _0x3f212a19.GetStatic<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[15] { 45, 59, 60, 60, 43, 32, 58, 15, 45, 58, 39, 56, 39, 58, 55 }, 78)))
        using (var _0xd4cb1255 = _0x99e1771a.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[9] { 96, 98, 115, 78, 105, 115, 98, 105, 115 }, 7)))
        {
            if (_0xd4cb1255 == null)
                return;
            using (var _0x78e27247 = _0xd4cb1255.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[9] { 143, 141, 156, 173, 144, 156, 154, 137, 155 }, 232)))
            {
                if (_0x78e27247 == null)
                    return;
                using (var _0x2f9425a0 = new AndroidJavaObject(_0x893dd4c5._0x4756ee13(new byte[19] { 208, 205, 216, 145, 213, 204, 208, 209, 145, 245, 236, 240, 241, 240, 221, 213, 218, 220, 203 }, 191)))
                using (var _0xe2341fcb = _0x78e27247.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[6] { 198, 200, 212, 254, 200, 217 }, 173)))
                using (var _0xb0181afb = _0xe2341fcb.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[8] { 86, 75, 90, 77, 94, 75, 80, 77 }, 63)))
                {
                    while (_0xb0181afb.Call<bool>(_0x893dd4c5._0x4756ee13(new byte[7] { 154, 147, 129, 188, 151, 138, 134 }, 242)))
                    {
                        string _0x363368c0 = _0xb0181afb.Call<string>(_0x893dd4c5._0x4756ee13(new byte[4] { 183, 188, 161, 173 }, 217));
                        using (var _0xd0928613 = _0x78e27247.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[3] { 253, 255, 238 }, 154), _0x363368c0))
                        {
                            _0x2f9425a0.Call<AndroidJavaObject>(_0x893dd4c5._0x4756ee13(new byte[3] { 54, 51, 50 }, 70), _0x363368c0, _0xd0928613);
                        }
                    }

                    string _0x36889be2 = _0x2f9425a0.Call<string>(_0x893dd4c5._0x4756ee13(new byte[8] { 24, 3, 63, 24, 30, 5, 2, 11 }, 108));
                    if (!string.IsNullOrEmpty(_0x36889be2))
                    {
                        _0x3c88b493(_0x36889be2);
                        _0x80834522(_0x36889be2);
                    }
                }
            }
        }
    }

    private void _0x3a3bfb7c(string _0xfa88668f)
    {
        if (string.IsNullOrEmpty(_0xfa88668f))
            return;
        if (TryOpenExternalLikeChrome(_0xfa88668f))
            return;
        OpenUrlExternally(_0xfa88668f);
    }

    private void _0x32db6a05()
    {
        WLog(_0x893dd4c5._0x4756ee13(new byte[21] { 221, 244, 231, 241, 226, 244, 231, 240, 181, 247, 244, 246, 254, 181, 229, 231, 240, 230, 230, 240, 241 }, 149));
        if (Time.frameCount == _0xec6c768e)
            return;
        _0xec6c768e = Time.frameCount;
        if (_0xd64d6308())
            return;
        _0x265b4be7();
    }

    private bool _0x81cb971e = false;
    private bool _0x5509ee3f()
    {
        _0xe57a15f9.RemoveAll(_0x103a8fc7 => _0x103a8fc7 == null || !_0x103a8fc7.IsAlive);
        return _0xe57a15f9.Count > 0;
    }

    private bool _0xf5295ddd = false;
    private Canvas _0xb0c6f995;
    private readonly string[] _0x589ae2b9 = new string[]
    {
        _0x893dd4c5._0x4756ee13(new byte[60] { 68, 43, 58, 4, 148, 224, 220, 209, 148, 198, 209, 209, 216, 199, 148, 213, 198, 209, 148, 220, 219, 192, 148, 198, 221, 211, 220, 192, 148, 218, 219, 195, 148, 86, 52, 39, 148, 208, 219, 218, 86, 52, 45, 192, 148, 217, 221, 199, 199, 148, 205, 219, 193, 198, 148, 199, 196, 221, 218, 149 }, 180),
        _0x893dd4c5._0x4756ee13(new byte[52] { 201, 166, 180, 185, 25, 112, 77, 25, 90, 86, 76, 85, 93, 25, 91, 92, 25, 64, 86, 76, 75, 25, 85, 76, 90, 82, 64, 25, 84, 86, 84, 92, 87, 77, 25, 219, 185, 170, 25, 78, 81, 64, 25, 74, 77, 86, 73, 25, 87, 86, 78, 6 }, 57),
        _0x893dd4c5._0x4756ee13(new byte[66] { 246, 142, 181, 251, 172, 155, 52, 86, 125, 115, 52, 99, 125, 122, 103, 52, 117, 102, 113, 52, 124, 125, 96, 96, 125, 122, 115, 52, 121, 123, 102, 113, 52, 123, 114, 96, 113, 122, 52, 96, 123, 112, 117, 109, 52, 246, 148, 135, 52, 103, 96, 117, 109, 52, 125, 122, 52, 96, 124, 113, 52, 115, 117, 121, 113, 58 }, 20),
        _0x893dd4c5._0x4756ee13(new byte[54] { 134, 233, 227, 228, 86, 34, 30, 31, 5, 86, 31, 5, 86, 6, 4, 31, 27, 19, 86, 2, 31, 27, 19, 86, 148, 246, 229, 86, 2, 30, 19, 86, 20, 19, 5, 2, 86, 6, 26, 23, 15, 19, 4, 5, 86, 6, 26, 23, 15, 86, 24, 25, 1, 88 }, 118),
        _0x893dd4c5._0x4756ee13(new byte[48] { 214, 185, 178, 131, 6, 127, 73, 83, 84, 6, 81, 79, 72, 72, 79, 72, 65, 6, 85, 82, 84, 67, 71, 77, 6, 69, 73, 83, 74, 66, 6, 68, 67, 6, 73, 72, 67, 6, 85, 86, 79, 72, 6, 71, 81, 71, 95, 8 }, 38),
        _0x893dd4c5._0x4756ee13(new byte[65] { 162, 205, 200, 210, 114, 24, 51, 49, 57, 34, 61, 38, 33, 114, 51, 32, 55, 114, 63, 61, 32, 55, 114, 51, 49, 38, 59, 36, 55, 114, 38, 61, 60, 59, 53, 58, 38, 114, 176, 210, 193, 114, 33, 38, 51, 43, 114, 51, 60, 54, 114, 38, 32, 43, 114, 43, 61, 39, 32, 114, 62, 39, 49, 57, 124 }, 82),
        _0x893dd4c5._0x4756ee13(new byte[55] { 229, 138, 155, 167, 53, 80, 99, 112, 103, 108, 53, 102, 101, 124, 123, 53, 118, 122, 96, 123, 97, 102, 53, 247, 149, 134, 53, 97, 125, 112, 53, 123, 112, 109, 97, 53, 122, 123, 112, 53, 118, 122, 96, 121, 113, 53, 119, 112, 53, 108, 122, 96, 103, 102, 59 }, 21),
        _0x893dd4c5._0x4756ee13(new byte[63] { 82, 29, 32, 95, 8, 63, 144, 224, 220, 209, 201, 213, 194, 195, 144, 194, 217, 215, 216, 196, 144, 222, 223, 199, 144, 209, 194, 213, 144, 199, 217, 222, 222, 217, 222, 215, 144, 82, 48, 35, 144, 212, 223, 222, 82, 48, 41, 196, 144, 199, 209, 220, 219, 144, 209, 199, 209, 201, 144, 201, 213, 196, 158 }, 176),
        _0x893dd4c5._0x4756ee13(new byte[51] { 0, 111, 127, 118, 208, 191, 158, 156, 137, 208, 132, 152, 159, 131, 149, 208, 135, 152, 159, 208, 131, 132, 145, 137, 208, 153, 158, 208, 132, 152, 149, 208, 151, 145, 157, 149, 208, 135, 153, 158, 208, 132, 152, 149, 208, 128, 130, 153, 138, 149, 222 }, 240),
        _0x893dd4c5._0x4756ee13(new byte[64] { 168, 208, 235, 165, 242, 197, 106, 7, 37, 39, 47, 36, 62, 63, 39, 106, 35, 57, 106, 47, 60, 47, 56, 51, 62, 34, 35, 36, 45, 106, 168, 202, 217, 106, 33, 47, 47, 58, 106, 57, 58, 35, 36, 36, 35, 36, 45, 106, 44, 37, 56, 106, 51, 37, 63, 56, 106, 41, 34, 43, 36, 41, 47, 100 }, 74)
    };
    private Task _0x9d993665(IEnumerator _0xae58ea1a)
    {
        var _0x0e65e1a6 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x45090e79(_0xae58ea1a, _0x0e65e1a6));
        return _0x0e65e1a6.Task;
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x2a58ba4a)
    {
        if (_0x2a58ba4a == null || _0x2a58ba4a.Extra == null)
            return null;
        object _0xbdc19173;
        if (!_0x2a58ba4a.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xbdc19173))
            return null;
        return _0xbdc19173 as string;
    }

    public void _0x15b2aac3()
    {
        if (_0xfceb9fa1)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x893dd4c5._0x4756ee13(new byte[33] { 103, 104, 89, 79, 72, 97, 28, 104, 85, 81, 89, 78, 28, 83, 73, 72, 28, 17, 2, 28, 81, 83, 74, 89, 28, 72, 83, 28, 79, 95, 89, 82, 89 }, 60));
            }
#endif
        }

        _0xa8b5b03d();
    }

    internal Vector2 lastSize = Vector2.zero;
    private string _0x6824fd07 = "";
    private void _0x6ad69106(string _0xe89af31c)
    {
        _0x931633c6();
        StartCoroutine(_0x45c44c3b(_0xe89af31c));
    }

    private string _0x5388e0c6()
    {
        string _0xe46b57a3 = _0xe23a5340();
        if (string.IsNullOrEmpty(_0xe46b57a3))
            return _0x893dd4c5._0x4756ee13(new byte[7] { 204, 213, 211, 222, 154, 138, 129 }, 186);
        string _0xbe0ae8c9 = _0xe46b57a3.Replace(_0x893dd4c5._0x4756ee13(new byte[1] { 132 }, 216), _0x893dd4c5._0x4756ee13(new byte[2] { 126, 126 }, 34)).Replace(_0x893dd4c5._0x4756ee13(new byte[1] { 20 }, 51), _0x893dd4c5._0x4756ee13(new byte[2] { 22, 109 }, 74));
        var _0xbc34fbce = Regex.Match(_0xe46b57a3, _0x893dd4c5._0x4756ee13(new byte[12] { 109, 70, 92, 65, 67, 75, 1, 6, 114, 74, 5, 7 }, 46));
        string _0xf83e414b = _0xbc34fbce.Success ? _0xbc34fbce.Groups[1].Value : _0x893dd4c5._0x4756ee13(new byte[3] { 235, 232, 234 }, 218);
        return _0x893dd4c5._0x4756ee13(new byte[12] { 219, 149, 134, 157, 144, 135, 154, 156, 157, 219, 218, 136 }, 243) + _0x893dd4c5._0x4756ee13(new byte[8] { 156, 139, 152, 202, 159, 139, 215, 205 }, 234) + _0xbe0ae8c9 + _0x893dd4c5._0x4756ee13(new byte[2] { 139, 151 }, 172) + _0x893dd4c5._0x4756ee13(new byte[30] { 83, 68, 87, 5, 85, 87, 74, 81, 74, 24, 107, 68, 83, 76, 66, 68, 81, 74, 87, 11, 85, 87, 74, 81, 74, 81, 92, 85, 64, 30 }, 37) + _0x893dd4c5._0x4756ee13(new byte[121] { 245, 230, 253, 240, 231, 250, 252, 253, 179, 247, 246, 245, 187, 252, 241, 249, 191, 248, 246, 234, 191, 229, 242, 255, 186, 232, 231, 225, 234, 232, 220, 241, 249, 246, 240, 231, 189, 247, 246, 245, 250, 253, 246, 195, 225, 252, 227, 246, 225, 231, 234, 187, 252, 241, 249, 191, 248, 246, 234, 191, 232, 244, 246, 231, 169, 245, 230, 253, 240, 231, 250, 252, 253, 187, 186, 232, 225, 246, 231, 230, 225, 253, 179, 229, 242, 255, 168, 238, 191, 240, 252, 253, 245, 250, 244, 230, 225, 242, 241, 255, 246, 169, 231, 225, 230, 246, 238, 186, 168, 238, 240, 242, 231, 240, 251, 187, 246, 186, 232, 238, 238 }, 147) + _0x893dd4c5._0x4756ee13(new byte[26] { 220, 221, 222, 144, 200, 202, 215, 204, 215, 148, 159, 205, 203, 221, 202, 249, 223, 221, 214, 204, 159, 148, 205, 217, 145, 131 }, 184) + _0x893dd4c5._0x4756ee13(new byte[52] { 12, 13, 14, 64, 24, 26, 7, 28, 7, 68, 79, 9, 24, 24, 62, 13, 26, 27, 1, 7, 6, 79, 68, 29, 9, 70, 26, 13, 24, 4, 9, 11, 13, 64, 71, 54, 37, 7, 18, 1, 4, 4, 9, 52, 71, 71, 68, 79, 79, 65, 65, 83 }, 104) + _0x893dd4c5._0x4756ee13(new byte[37] { 128, 129, 130, 204, 148, 150, 139, 144, 139, 200, 195, 148, 136, 133, 144, 130, 139, 150, 137, 195, 200, 195, 168, 141, 138, 145, 156, 196, 133, 150, 137, 146, 220, 136, 195, 205, 223 }, 228) + _0x893dd4c5._0x4756ee13(new byte[34] { 81, 80, 83, 29, 69, 71, 90, 65, 90, 25, 18, 67, 80, 91, 81, 90, 71, 18, 25, 18, 114, 90, 90, 82, 89, 80, 21, 124, 91, 86, 27, 18, 28, 14 }, 53) + _0x893dd4c5._0x4756ee13(new byte[30] { 107, 106, 105, 39, 127, 125, 96, 123, 96, 35, 40, 98, 110, 119, 91, 96, 122, 108, 103, 95, 96, 102, 97, 123, 124, 40, 35, 58, 38, 52 }, 15) + _0x893dd4c5._0x4756ee13(new byte[48] { 12, 10, 1, 3, 14, 25, 10, 88, 13, 25, 28, 69, 3, 26, 10, 25, 22, 28, 11, 66, 35, 3, 26, 10, 25, 22, 28, 66, 95, 59, 16, 10, 23, 21, 17, 13, 21, 95, 84, 14, 29, 10, 11, 17, 23, 22, 66, 95 }, 120) + _0xf83e414b + _0x893dd4c5._0x4756ee13(new byte[35] { 9, 83, 2, 85, 76, 92, 79, 64, 74, 20, 9, 105, 65, 65, 73, 66, 75, 14, 109, 70, 92, 65, 67, 75, 9, 2, 88, 75, 92, 93, 71, 65, 64, 20, 9 }, 46) + _0xf83e414b + _0x893dd4c5._0x4756ee13(new byte[238] { 232, 178, 227, 180, 173, 189, 174, 161, 171, 245, 232, 129, 160, 187, 242, 142, 240, 141, 189, 174, 161, 171, 232, 227, 185, 170, 189, 188, 166, 160, 161, 245, 232, 253, 251, 232, 178, 146, 227, 162, 160, 173, 166, 163, 170, 245, 187, 189, 186, 170, 227, 191, 163, 174, 187, 169, 160, 189, 162, 245, 232, 142, 161, 171, 189, 160, 166, 171, 232, 227, 168, 170, 187, 135, 166, 168, 167, 138, 161, 187, 189, 160, 191, 182, 153, 174, 163, 186, 170, 188, 245, 169, 186, 161, 172, 187, 166, 160, 161, 231, 230, 180, 189, 170, 187, 186, 189, 161, 239, 159, 189, 160, 162, 166, 188, 170, 225, 189, 170, 188, 160, 163, 185, 170, 231, 180, 174, 189, 172, 167, 166, 187, 170, 172, 187, 186, 189, 170, 245, 232, 174, 189, 162, 232, 227, 173, 166, 187, 161, 170, 188, 188, 245, 232, 249, 251, 232, 227, 162, 160, 173, 166, 163, 170, 245, 187, 189, 186, 170, 227, 162, 160, 171, 170, 163, 245, 232, 232, 227, 191, 163, 174, 187, 169, 160, 189, 162, 245, 232, 142, 161, 171, 189, 160, 166, 171, 232, 227, 191, 163, 174, 187, 169, 160, 189, 162, 153, 170, 189, 188, 166, 160, 161, 245, 232, 254, 251, 225, 255, 225, 255, 232, 227, 186, 174, 137, 186, 163, 163, 153, 170, 189, 188, 166, 160, 161, 245, 232 }, 207) + _0xf83e414b + _0x893dd4c5._0x4756ee13(new byte[117] { 235, 245, 235, 245, 235, 245, 226, 184, 236, 254, 184, 184, 254, 138, 167, 175, 160, 166, 177, 235, 161, 160, 163, 172, 171, 160, 149, 183, 170, 181, 160, 183, 177, 188, 237, 181, 183, 170, 177, 170, 233, 226, 176, 182, 160, 183, 132, 162, 160, 171, 177, 129, 164, 177, 164, 226, 233, 190, 162, 160, 177, 255, 163, 176, 171, 166, 177, 172, 170, 171, 237, 236, 190, 183, 160, 177, 176, 183, 171, 229, 176, 164, 161, 254, 184, 233, 166, 170, 171, 163, 172, 162, 176, 183, 164, 167, 169, 160, 255, 177, 183, 176, 160, 184, 236, 254, 184, 166, 164, 177, 166, 173, 237, 160, 236, 190, 184 }, 197) + _0x893dd4c5._0x4756ee13(new byte[5] { 230, 178, 179, 178, 160 }, 155);
    }

    private UniWebViewPopup _0x7eafae23()
    {
        for (int _0xbbcc2ecb = _0xe57a15f9.Count - 1; _0xbbcc2ecb >= 0; _0xbbcc2ecb--)
        {
            var _0xe5f1289d = _0xe57a15f9[_0xbbcc2ecb];
            if (_0xe5f1289d != null && _0xe5f1289d.IsAlive)
                return _0xe5f1289d;
            _0xe57a15f9.RemoveAt(_0xbbcc2ecb);
        }

        return null;
    }

    private void _0xa4f9701d(bool _0x92c1cb92)
    {
        _0x0cc4c1b8();
        _0x98b89ec5.SetActive(_0x92c1cb92);
        _0x51b14c75 = _0x92c1cb92;
        if (_0x92c1cb92)
        {
            _0x98b89ec5.transform.SetAsLastSibling();
            if (_0x2a25f1e0 != null)
                _0x2a25f1e0.localRotation = Quaternion.identity;
        }
    }

    private string _0xa5f4d7b0 = "";
    internal bool IsHttpUrl(string _0x218a5b17)
    {
        if (string.IsNullOrEmpty(_0x218a5b17))
            return false;
        return _0x218a5b17.StartsWith(_0x893dd4c5._0x4756ee13(new byte[7] { 103, 123, 123, 127, 53, 32, 32 }, 15), StringComparison.OrdinalIgnoreCase) || _0x218a5b17.StartsWith(_0x893dd4c5._0x4756ee13(new byte[8] { 168, 180, 180, 176, 179, 250, 239, 239 }, 192), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0xd64d6308()
    {
        if (_0xc1b879a6())
            return true;
        if (_0x5f57ded1 != null && _0x5f57ded1.CanGoBack)
        {
            WLog(_0x893dd4c5._0x4756ee13(new byte[36] { 96, 73, 90, 76, 95, 73, 90, 77, 8, 74, 73, 75, 67, 8, 5, 22, 8, 69, 73, 65, 70, 8, 127, 77, 74, 126, 65, 77, 95, 8, 111, 71, 106, 73, 75, 67 }, 40));
            _0x5f57ded1.GoBack();
            return true;
        }

        return false;
    }
}

internal static class _0x893dd4c5
{
    internal static string _0x4756ee13(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}