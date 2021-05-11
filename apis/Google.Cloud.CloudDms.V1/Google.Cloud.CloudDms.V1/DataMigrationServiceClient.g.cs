// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.CloudDms.V1
{
    /// <summary>Settings for <see cref="DataMigrationServiceClient"/> instances.</summary>
    public sealed partial class DataMigrationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataMigrationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataMigrationServiceSettings"/>.</returns>
        public static DataMigrationServiceSettings GetDefault() => new DataMigrationServiceSettings();

        /// <summary>Constructs a new <see cref="DataMigrationServiceSettings"/> object with default settings.</summary>
        public DataMigrationServiceSettings()
        {
        }

        private DataMigrationServiceSettings(DataMigrationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListMigrationJobsSettings = existing.ListMigrationJobsSettings;
            GetMigrationJobSettings = existing.GetMigrationJobSettings;
            CreateMigrationJobSettings = existing.CreateMigrationJobSettings;
            CreateMigrationJobOperationsSettings = existing.CreateMigrationJobOperationsSettings.Clone();
            UpdateMigrationJobSettings = existing.UpdateMigrationJobSettings;
            UpdateMigrationJobOperationsSettings = existing.UpdateMigrationJobOperationsSettings.Clone();
            DeleteMigrationJobSettings = existing.DeleteMigrationJobSettings;
            DeleteMigrationJobOperationsSettings = existing.DeleteMigrationJobOperationsSettings.Clone();
            StartMigrationJobSettings = existing.StartMigrationJobSettings;
            StartMigrationJobOperationsSettings = existing.StartMigrationJobOperationsSettings.Clone();
            StopMigrationJobSettings = existing.StopMigrationJobSettings;
            StopMigrationJobOperationsSettings = existing.StopMigrationJobOperationsSettings.Clone();
            ResumeMigrationJobSettings = existing.ResumeMigrationJobSettings;
            ResumeMigrationJobOperationsSettings = existing.ResumeMigrationJobOperationsSettings.Clone();
            PromoteMigrationJobSettings = existing.PromoteMigrationJobSettings;
            PromoteMigrationJobOperationsSettings = existing.PromoteMigrationJobOperationsSettings.Clone();
            VerifyMigrationJobSettings = existing.VerifyMigrationJobSettings;
            VerifyMigrationJobOperationsSettings = existing.VerifyMigrationJobOperationsSettings.Clone();
            RestartMigrationJobSettings = existing.RestartMigrationJobSettings;
            RestartMigrationJobOperationsSettings = existing.RestartMigrationJobOperationsSettings.Clone();
            GenerateSshScriptSettings = existing.GenerateSshScriptSettings;
            ListConnectionProfilesSettings = existing.ListConnectionProfilesSettings;
            GetConnectionProfileSettings = existing.GetConnectionProfileSettings;
            CreateConnectionProfileSettings = existing.CreateConnectionProfileSettings;
            CreateConnectionProfileOperationsSettings = existing.CreateConnectionProfileOperationsSettings.Clone();
            UpdateConnectionProfileSettings = existing.UpdateConnectionProfileSettings;
            UpdateConnectionProfileOperationsSettings = existing.UpdateConnectionProfileOperationsSettings.Clone();
            DeleteConnectionProfileSettings = existing.DeleteConnectionProfileSettings;
            DeleteConnectionProfileOperationsSettings = existing.DeleteConnectionProfileOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(DataMigrationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.ListMigrationJobs</c> and <c>DataMigrationServiceClient.ListMigrationJobsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMigrationJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.GetMigrationJob</c> and <c>DataMigrationServiceClient.GetMigrationJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.CreateMigrationJob</c> and
        /// <c>DataMigrationServiceClient.CreateMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.CreateMigrationJob</c> and
        /// <c>DataMigrationServiceClient.CreateMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.UpdateMigrationJob</c> and
        /// <c>DataMigrationServiceClient.UpdateMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.UpdateMigrationJob</c> and
        /// <c>DataMigrationServiceClient.UpdateMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.DeleteMigrationJob</c> and
        /// <c>DataMigrationServiceClient.DeleteMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.DeleteMigrationJob</c> and
        /// <c>DataMigrationServiceClient.DeleteMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.StartMigrationJob</c> and <c>DataMigrationServiceClient.StartMigrationJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.StartMigrationJob</c> and
        /// <c>DataMigrationServiceClient.StartMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings StartMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.StopMigrationJob</c> and <c>DataMigrationServiceClient.StopMigrationJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.StopMigrationJob</c> and
        /// <c>DataMigrationServiceClient.StopMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings StopMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.ResumeMigrationJob</c> and
        /// <c>DataMigrationServiceClient.ResumeMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.ResumeMigrationJob</c> and
        /// <c>DataMigrationServiceClient.ResumeMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ResumeMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.PromoteMigrationJob</c> and
        /// <c>DataMigrationServiceClient.PromoteMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PromoteMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.PromoteMigrationJob</c> and
        /// <c>DataMigrationServiceClient.PromoteMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings PromoteMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.VerifyMigrationJob</c> and
        /// <c>DataMigrationServiceClient.VerifyMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings VerifyMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.VerifyMigrationJob</c> and
        /// <c>DataMigrationServiceClient.VerifyMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings VerifyMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.RestartMigrationJob</c> and
        /// <c>DataMigrationServiceClient.RestartMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestartMigrationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.RestartMigrationJob</c> and
        /// <c>DataMigrationServiceClient.RestartMigrationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RestartMigrationJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.GenerateSshScript</c> and <c>DataMigrationServiceClient.GenerateSshScriptAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateSshScriptSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.ListConnectionProfiles</c> and
        /// <c>DataMigrationServiceClient.ListConnectionProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConnectionProfilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.GetConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.GetConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConnectionProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.CreateConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.CreateConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConnectionProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.CreateConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.CreateConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateConnectionProfileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.UpdateConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.UpdateConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConnectionProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.UpdateConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.UpdateConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateConnectionProfileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataMigrationServiceClient.DeleteConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.DeleteConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConnectionProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataMigrationServiceClient.DeleteConnectionProfile</c> and
        /// <c>DataMigrationServiceClient.DeleteConnectionProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteConnectionProfileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataMigrationServiceSettings"/> object.</returns>
        public DataMigrationServiceSettings Clone() => new DataMigrationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataMigrationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DataMigrationServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataMigrationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataMigrationServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref DataMigrationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataMigrationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataMigrationServiceClient Build()
        {
            DataMigrationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataMigrationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataMigrationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataMigrationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataMigrationServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<DataMigrationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataMigrationServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => DataMigrationServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DataMigrationServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataMigrationServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>DataMigrationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Database Migration service
    /// </remarks>
    public abstract partial class DataMigrationServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataMigrationService service, which is a host of "datamigration.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datamigration.googleapis.com:443";

        /// <summary>The default DataMigrationService scopes.</summary>
        /// <remarks>
        /// The default DataMigrationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="DataMigrationServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DataMigrationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataMigrationServiceClient"/>.</returns>
        public static stt::Task<DataMigrationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataMigrationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataMigrationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DataMigrationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataMigrationServiceClient"/>.</returns>
        public static DataMigrationServiceClient Create() => new DataMigrationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataMigrationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataMigrationServiceSettings"/>.</param>
        /// <returns>The created <see cref="DataMigrationServiceClient"/>.</returns>
        internal static DataMigrationServiceClient Create(grpccore::CallInvoker callInvoker, DataMigrationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataMigrationService.DataMigrationServiceClient grpcClient = new DataMigrationService.DataMigrationServiceClient(callInvoker);
            return new DataMigrationServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC DataMigrationService client</summary>
        public virtual DataMigrationService.DataMigrationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MigrationJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobs(ListMigrationJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobsAsync(ListMigrationJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migrationJobs.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MigrationJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMigrationJobs(new ListMigrationJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migrationJobs.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMigrationJobsAsync(new ListMigrationJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migrationJobs.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MigrationJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMigrationJobs(new ListMigrationJobsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migrationJobs.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMigrationJobsAsync(new ListMigrationJobsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationJob GetMigrationJob(GetMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationJob> GetMigrationJobAsync(GetMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationJob> GetMigrationJobAsync(GetMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            GetMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationJob GetMigrationJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationJob(new GetMigrationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationJob> GetMigrationJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationJobAsync(new GetMigrationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationJob> GetMigrationJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetMigrationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationJob GetMigrationJob(MigrationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationJob(new GetMigrationJobRequest
            {
                MigrationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationJob> GetMigrationJobAsync(MigrationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationJobAsync(new GetMigrationJobRequest
            {
                MigrationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationJob> GetMigrationJobAsync(MigrationJobName name, st::CancellationToken cancellationToken) =>
            GetMigrationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> CreateMigrationJob(CreateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(CreateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(CreateMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            CreateMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMigrationJob</c>.</summary>
        public virtual lro::OperationsClient CreateMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceCreateMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceCreateMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migration jobs.
        /// </param>
        /// <param name="migrationJob">
        /// Required. Represents a [migration
        /// job](https://cloud.google.com/database-migration/reference/rest/v1/projects.locations.migrationJobs)
        /// object.
        /// </param>
        /// <param name="migrationJobId">
        /// Required. The ID of the instance to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> CreateMigrationJob(string parent, MigrationJob migrationJob, string migrationJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigrationJob(new CreateMigrationJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MigrationJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(migrationJobId, nameof(migrationJobId)),
                MigrationJob = gax::GaxPreconditions.CheckNotNull(migrationJob, nameof(migrationJob)),
            }, callSettings);

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migration jobs.
        /// </param>
        /// <param name="migrationJob">
        /// Required. Represents a [migration
        /// job](https://cloud.google.com/database-migration/reference/rest/v1/projects.locations.migrationJobs)
        /// object.
        /// </param>
        /// <param name="migrationJobId">
        /// Required. The ID of the instance to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(string parent, MigrationJob migrationJob, string migrationJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigrationJobAsync(new CreateMigrationJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MigrationJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(migrationJobId, nameof(migrationJobId)),
                MigrationJob = gax::GaxPreconditions.CheckNotNull(migrationJob, nameof(migrationJob)),
            }, callSettings);

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migration jobs.
        /// </param>
        /// <param name="migrationJob">
        /// Required. Represents a [migration
        /// job](https://cloud.google.com/database-migration/reference/rest/v1/projects.locations.migrationJobs)
        /// object.
        /// </param>
        /// <param name="migrationJobId">
        /// Required. The ID of the instance to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(string parent, MigrationJob migrationJob, string migrationJobId, st::CancellationToken cancellationToken) =>
            CreateMigrationJobAsync(parent, migrationJob, migrationJobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migration jobs.
        /// </param>
        /// <param name="migrationJob">
        /// Required. Represents a [migration
        /// job](https://cloud.google.com/database-migration/reference/rest/v1/projects.locations.migrationJobs)
        /// object.
        /// </param>
        /// <param name="migrationJobId">
        /// Required. The ID of the instance to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> CreateMigrationJob(gagr::LocationName parent, MigrationJob migrationJob, string migrationJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigrationJob(new CreateMigrationJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MigrationJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(migrationJobId, nameof(migrationJobId)),
                MigrationJob = gax::GaxPreconditions.CheckNotNull(migrationJob, nameof(migrationJob)),
            }, callSettings);

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migration jobs.
        /// </param>
        /// <param name="migrationJob">
        /// Required. Represents a [migration
        /// job](https://cloud.google.com/database-migration/reference/rest/v1/projects.locations.migrationJobs)
        /// object.
        /// </param>
        /// <param name="migrationJobId">
        /// Required. The ID of the instance to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(gagr::LocationName parent, MigrationJob migrationJob, string migrationJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigrationJobAsync(new CreateMigrationJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MigrationJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(migrationJobId, nameof(migrationJobId)),
                MigrationJob = gax::GaxPreconditions.CheckNotNull(migrationJob, nameof(migrationJob)),
            }, callSettings);

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migration jobs.
        /// </param>
        /// <param name="migrationJob">
        /// Required. Represents a [migration
        /// job](https://cloud.google.com/database-migration/reference/rest/v1/projects.locations.migrationJobs)
        /// object.
        /// </param>
        /// <param name="migrationJobId">
        /// Required. The ID of the instance to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(gagr::LocationName parent, MigrationJob migrationJob, string migrationJobId, st::CancellationToken cancellationToken) =>
            CreateMigrationJobAsync(parent, migrationJob, migrationJobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> UpdateMigrationJob(UpdateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> UpdateMigrationJobAsync(UpdateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> UpdateMigrationJobAsync(UpdateMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            UpdateMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMigrationJob</c>.</summary>
        public virtual lro::OperationsClient UpdateMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceUpdateMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceUpdateMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="migrationJob">
        /// Required. The migration job parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// migration job resource by the update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> UpdateMigrationJob(MigrationJob migrationJob, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMigrationJob(new UpdateMigrationJobRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                MigrationJob = gax::GaxPreconditions.CheckNotNull(migrationJob, nameof(migrationJob)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="migrationJob">
        /// Required. The migration job parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// migration job resource by the update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> UpdateMigrationJobAsync(MigrationJob migrationJob, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMigrationJobAsync(new UpdateMigrationJobRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                MigrationJob = gax::GaxPreconditions.CheckNotNull(migrationJob, nameof(migrationJob)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="migrationJob">
        /// Required. The migration job parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// migration job resource by the update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> UpdateMigrationJobAsync(MigrationJob migrationJob, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMigrationJobAsync(migrationJob, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMigrationJob(DeleteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(DeleteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(DeleteMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMigrationJob</c>.</summary>
        public virtual lro::OperationsClient DeleteMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMigrationJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigrationJob(new DeleteMigrationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigrationJobAsync(new DeleteMigrationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMigrationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMigrationJob(MigrationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigrationJob(new DeleteMigrationJobRequest
            {
                MigrationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(MigrationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigrationJobAsync(new DeleteMigrationJobRequest
            {
                MigrationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the migration job resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(MigrationJobName name, st::CancellationToken cancellationToken) =>
            DeleteMigrationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Start an already created migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> StartMigrationJob(StartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Start an already created migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> StartMigrationJobAsync(StartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Start an already created migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> StartMigrationJobAsync(StartMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            StartMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartMigrationJob</c>.</summary>
        public virtual lro::OperationsClient StartMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceStartMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceStartMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Stops a running migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> StopMigrationJob(StopMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a running migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> StopMigrationJobAsync(StopMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a running migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> StopMigrationJobAsync(StopMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            StopMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopMigrationJob</c>.</summary>
        public virtual lro::OperationsClient StopMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StopMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceStopMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceStopMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Resume a migration job that is currently stopped and is resumable (was
        /// stopped during CDC phase).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> ResumeMigrationJob(ResumeMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume a migration job that is currently stopped and is resumable (was
        /// stopped during CDC phase).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> ResumeMigrationJobAsync(ResumeMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume a migration job that is currently stopped and is resumable (was
        /// stopped during CDC phase).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> ResumeMigrationJobAsync(ResumeMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            ResumeMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResumeMigrationJob</c>.</summary>
        public virtual lro::OperationsClient ResumeMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResumeMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceResumeMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResumeMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceResumeMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Promote a migration job, stopping replication to the destination and
        /// promoting the destination to be a standalone database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PromoteMigrationJob(PromoteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promote a migration job, stopping replication to the destination and
        /// promoting the destination to be a standalone database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PromoteMigrationJobAsync(PromoteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promote a migration job, stopping replication to the destination and
        /// promoting the destination to be a standalone database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PromoteMigrationJobAsync(PromoteMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            PromoteMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PromoteMigrationJob</c>.</summary>
        public virtual lro::OperationsClient PromoteMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PromoteMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOncePromoteMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PromoteMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOncePromoteMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Verify a migration job, making sure the destination can reach the source
        /// and that all configuration and prerequisites are met.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> VerifyMigrationJob(VerifyMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verify a migration job, making sure the destination can reach the source
        /// and that all configuration and prerequisites are met.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> VerifyMigrationJobAsync(VerifyMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verify a migration job, making sure the destination can reach the source
        /// and that all configuration and prerequisites are met.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> VerifyMigrationJobAsync(VerifyMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            VerifyMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>VerifyMigrationJob</c>.</summary>
        public virtual lro::OperationsClient VerifyMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>VerifyMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceVerifyMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), VerifyMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>VerifyMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceVerifyMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), VerifyMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Restart a stopped or failed migration job, resetting the destination
        /// instance to its original state and starting the migration process from
        /// scratch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> RestartMigrationJob(RestartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restart a stopped or failed migration job, resetting the destination
        /// instance to its original state and starting the migration process from
        /// scratch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> RestartMigrationJobAsync(RestartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restart a stopped or failed migration job, resetting the destination
        /// instance to its original state and starting the migration process from
        /// scratch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> RestartMigrationJobAsync(RestartMigrationJobRequest request, st::CancellationToken cancellationToken) =>
            RestartMigrationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestartMigrationJob</c>.</summary>
        public virtual lro::OperationsClient RestartMigrationJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestartMigrationJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigrationJob, OperationMetadata> PollOnceRestartMigrationJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestartMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestartMigrationJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PollOnceRestartMigrationJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigrationJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestartMigrationJobOperationsClient, callSettings);

        /// <summary>
        /// Generate a SSH configuration script to configure the reverse SSH
        /// connectivity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SshScript GenerateSshScript(GenerateSshScriptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate a SSH configuration script to configure the reverse SSH
        /// connectivity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SshScript> GenerateSshScriptAsync(GenerateSshScriptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate a SSH configuration script to configure the reverse SSH
        /// connectivity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SshScript> GenerateSshScriptAsync(GenerateSshScriptRequest request, st::CancellationToken cancellationToken) =>
            GenerateSshScriptAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a list of all connection profiles in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfiles(ListConnectionProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a list of all connection profiles in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfilesAsync(ListConnectionProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a list of all connection profiles in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connection profiles.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConnectionProfiles(new ListConnectionProfilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieve a list of all connection profiles in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connection profiles.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConnectionProfilesAsync(new ListConnectionProfilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieve a list of all connection profiles in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connection profiles.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfiles(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConnectionProfiles(new ListConnectionProfilesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieve a list of all connection profiles in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connection profiles.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfilesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConnectionProfilesAsync(new ListConnectionProfilesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionProfile GetConnectionProfile(GetConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(GetConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(GetConnectionProfileRequest request, st::CancellationToken cancellationToken) =>
            GetConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionProfile GetConnectionProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionProfile(new GetConnectionProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionProfileAsync(new GetConnectionProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectionProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionProfile GetConnectionProfile(ConnectionProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionProfile(new GetConnectionProfileRequest
            {
                ConnectionProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(ConnectionProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionProfileAsync(new GetConnectionProfileRequest
            {
                ConnectionProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionProfile> GetConnectionProfileAsync(ConnectionProfileName name, st::CancellationToken cancellationToken) =>
            GetConnectionProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> CreateConnectionProfile(CreateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(CreateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(CreateConnectionProfileRequest request, st::CancellationToken cancellationToken) =>
            CreateConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConnectionProfile</c>.</summary>
        public virtual lro::OperationsClient CreateConnectionProfileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> PollOnceCreateConnectionProfile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionProfile, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> PollOnceCreateConnectionProfileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionProfile, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connection profiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The create request body including the connection profile data
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> CreateConnectionProfile(string parent, ConnectionProfile connectionProfile, string connectionProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionProfile(new CreateConnectionProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectionProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connection profiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The create request body including the connection profile data
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(string parent, ConnectionProfile connectionProfile, string connectionProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionProfileAsync(new CreateConnectionProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectionProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connection profiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The create request body including the connection profile data
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(string parent, ConnectionProfile connectionProfile, string connectionProfileId, st::CancellationToken cancellationToken) =>
            CreateConnectionProfileAsync(parent, connectionProfile, connectionProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connection profiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The create request body including the connection profile data
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> CreateConnectionProfile(ConnectionProfileName parent, ConnectionProfile connectionProfile, string connectionProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionProfile(new CreateConnectionProfileRequest
            {
                ParentAsConnectionProfileName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectionProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connection profiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The create request body including the connection profile data
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(ConnectionProfileName parent, ConnectionProfile connectionProfile, string connectionProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionProfileAsync(new CreateConnectionProfileRequest
            {
                ParentAsConnectionProfileName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectionProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connection profiles.
        /// </param>
        /// <param name="connectionProfile">
        /// Required. The create request body including the connection profile data
        /// </param>
        /// <param name="connectionProfileId">
        /// Required. The connection profile identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(ConnectionProfileName parent, ConnectionProfile connectionProfile, string connectionProfileId, st::CancellationToken cancellationToken) =>
            CreateConnectionProfileAsync(parent, connectionProfile, connectionProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> UpdateConnectionProfile(UpdateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(UpdateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(UpdateConnectionProfileRequest request, st::CancellationToken cancellationToken) =>
            UpdateConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateConnectionProfile</c>.</summary>
        public virtual lro::OperationsClient UpdateConnectionProfileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> PollOnceUpdateConnectionProfile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionProfile, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> PollOnceUpdateConnectionProfileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectionProfile, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="connectionProfile">
        /// Required. The connection profile parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// connection profile resource by the update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectionProfile, OperationMetadata> UpdateConnectionProfile(ConnectionProfile connectionProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectionProfile(new UpdateConnectionProfileRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="connectionProfile">
        /// Required. The connection profile parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// connection profile resource by the update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(ConnectionProfile connectionProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectionProfileAsync(new UpdateConnectionProfileRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ConnectionProfile = gax::GaxPreconditions.CheckNotNull(connectionProfile, nameof(connectionProfile)),
            }, callSettings);

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="connectionProfile">
        /// Required. The connection profile parameters to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// connection profile resource by the update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(ConnectionProfile connectionProfile, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConnectionProfileAsync(connectionProfile, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectionProfile(DeleteConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(DeleteConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(DeleteConnectionProfileRequest request, st::CancellationToken cancellationToken) =>
            DeleteConnectionProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteConnectionProfile</c>.</summary>
        public virtual lro::OperationsClient DeleteConnectionProfileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteConnectionProfile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConnectionProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteConnectionProfileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectionProfileOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectionProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionProfile(new DeleteConnectionProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionProfileAsync(new DeleteConnectionProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConnectionProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectionProfile(ConnectionProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionProfile(new DeleteConnectionProfileRequest
            {
                ConnectionProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(ConnectionProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionProfileAsync(new DeleteConnectionProfileRequest
            {
                ConnectionProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the connection profile resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(ConnectionProfileName name, st::CancellationToken cancellationToken) =>
            DeleteConnectionProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataMigrationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Database Migration service
    /// </remarks>
    public sealed partial class DataMigrationServiceClientImpl : DataMigrationServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListMigrationJobsRequest, ListMigrationJobsResponse> _callListMigrationJobs;

        private readonly gaxgrpc::ApiCall<GetMigrationJobRequest, MigrationJob> _callGetMigrationJob;

        private readonly gaxgrpc::ApiCall<CreateMigrationJobRequest, lro::Operation> _callCreateMigrationJob;

        private readonly gaxgrpc::ApiCall<UpdateMigrationJobRequest, lro::Operation> _callUpdateMigrationJob;

        private readonly gaxgrpc::ApiCall<DeleteMigrationJobRequest, lro::Operation> _callDeleteMigrationJob;

        private readonly gaxgrpc::ApiCall<StartMigrationJobRequest, lro::Operation> _callStartMigrationJob;

        private readonly gaxgrpc::ApiCall<StopMigrationJobRequest, lro::Operation> _callStopMigrationJob;

        private readonly gaxgrpc::ApiCall<ResumeMigrationJobRequest, lro::Operation> _callResumeMigrationJob;

        private readonly gaxgrpc::ApiCall<PromoteMigrationJobRequest, lro::Operation> _callPromoteMigrationJob;

        private readonly gaxgrpc::ApiCall<VerifyMigrationJobRequest, lro::Operation> _callVerifyMigrationJob;

        private readonly gaxgrpc::ApiCall<RestartMigrationJobRequest, lro::Operation> _callRestartMigrationJob;

        private readonly gaxgrpc::ApiCall<GenerateSshScriptRequest, SshScript> _callGenerateSshScript;

        private readonly gaxgrpc::ApiCall<ListConnectionProfilesRequest, ListConnectionProfilesResponse> _callListConnectionProfiles;

        private readonly gaxgrpc::ApiCall<GetConnectionProfileRequest, ConnectionProfile> _callGetConnectionProfile;

        private readonly gaxgrpc::ApiCall<CreateConnectionProfileRequest, lro::Operation> _callCreateConnectionProfile;

        private readonly gaxgrpc::ApiCall<UpdateConnectionProfileRequest, lro::Operation> _callUpdateConnectionProfile;

        private readonly gaxgrpc::ApiCall<DeleteConnectionProfileRequest, lro::Operation> _callDeleteConnectionProfile;

        /// <summary>
        /// Constructs a client wrapper for the DataMigrationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataMigrationServiceSettings"/> used within this client.</param>
        public DataMigrationServiceClientImpl(DataMigrationService.DataMigrationServiceClient grpcClient, DataMigrationServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DataMigrationServiceSettings effectiveSettings = settings ?? DataMigrationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMigrationJobOperationsSettings);
            UpdateMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMigrationJobOperationsSettings);
            DeleteMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMigrationJobOperationsSettings);
            StartMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartMigrationJobOperationsSettings);
            StopMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopMigrationJobOperationsSettings);
            ResumeMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResumeMigrationJobOperationsSettings);
            PromoteMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PromoteMigrationJobOperationsSettings);
            VerifyMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.VerifyMigrationJobOperationsSettings);
            RestartMigrationJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestartMigrationJobOperationsSettings);
            CreateConnectionProfileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConnectionProfileOperationsSettings);
            UpdateConnectionProfileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateConnectionProfileOperationsSettings);
            DeleteConnectionProfileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConnectionProfileOperationsSettings);
            _callListMigrationJobs = clientHelper.BuildApiCall<ListMigrationJobsRequest, ListMigrationJobsResponse>(grpcClient.ListMigrationJobsAsync, grpcClient.ListMigrationJobs, effectiveSettings.ListMigrationJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMigrationJobs);
            Modify_ListMigrationJobsApiCall(ref _callListMigrationJobs);
            _callGetMigrationJob = clientHelper.BuildApiCall<GetMigrationJobRequest, MigrationJob>(grpcClient.GetMigrationJobAsync, grpcClient.GetMigrationJob, effectiveSettings.GetMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMigrationJob);
            Modify_GetMigrationJobApiCall(ref _callGetMigrationJob);
            _callCreateMigrationJob = clientHelper.BuildApiCall<CreateMigrationJobRequest, lro::Operation>(grpcClient.CreateMigrationJobAsync, grpcClient.CreateMigrationJob, effectiveSettings.CreateMigrationJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMigrationJob);
            Modify_CreateMigrationJobApiCall(ref _callCreateMigrationJob);
            _callUpdateMigrationJob = clientHelper.BuildApiCall<UpdateMigrationJobRequest, lro::Operation>(grpcClient.UpdateMigrationJobAsync, grpcClient.UpdateMigrationJob, effectiveSettings.UpdateMigrationJobSettings).WithGoogleRequestParam("migration_job.name", request => request.MigrationJob?.Name);
            Modify_ApiCall(ref _callUpdateMigrationJob);
            Modify_UpdateMigrationJobApiCall(ref _callUpdateMigrationJob);
            _callDeleteMigrationJob = clientHelper.BuildApiCall<DeleteMigrationJobRequest, lro::Operation>(grpcClient.DeleteMigrationJobAsync, grpcClient.DeleteMigrationJob, effectiveSettings.DeleteMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMigrationJob);
            Modify_DeleteMigrationJobApiCall(ref _callDeleteMigrationJob);
            _callStartMigrationJob = clientHelper.BuildApiCall<StartMigrationJobRequest, lro::Operation>(grpcClient.StartMigrationJobAsync, grpcClient.StartMigrationJob, effectiveSettings.StartMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartMigrationJob);
            Modify_StartMigrationJobApiCall(ref _callStartMigrationJob);
            _callStopMigrationJob = clientHelper.BuildApiCall<StopMigrationJobRequest, lro::Operation>(grpcClient.StopMigrationJobAsync, grpcClient.StopMigrationJob, effectiveSettings.StopMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopMigrationJob);
            Modify_StopMigrationJobApiCall(ref _callStopMigrationJob);
            _callResumeMigrationJob = clientHelper.BuildApiCall<ResumeMigrationJobRequest, lro::Operation>(grpcClient.ResumeMigrationJobAsync, grpcClient.ResumeMigrationJob, effectiveSettings.ResumeMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeMigrationJob);
            Modify_ResumeMigrationJobApiCall(ref _callResumeMigrationJob);
            _callPromoteMigrationJob = clientHelper.BuildApiCall<PromoteMigrationJobRequest, lro::Operation>(grpcClient.PromoteMigrationJobAsync, grpcClient.PromoteMigrationJob, effectiveSettings.PromoteMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPromoteMigrationJob);
            Modify_PromoteMigrationJobApiCall(ref _callPromoteMigrationJob);
            _callVerifyMigrationJob = clientHelper.BuildApiCall<VerifyMigrationJobRequest, lro::Operation>(grpcClient.VerifyMigrationJobAsync, grpcClient.VerifyMigrationJob, effectiveSettings.VerifyMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callVerifyMigrationJob);
            Modify_VerifyMigrationJobApiCall(ref _callVerifyMigrationJob);
            _callRestartMigrationJob = clientHelper.BuildApiCall<RestartMigrationJobRequest, lro::Operation>(grpcClient.RestartMigrationJobAsync, grpcClient.RestartMigrationJob, effectiveSettings.RestartMigrationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestartMigrationJob);
            Modify_RestartMigrationJobApiCall(ref _callRestartMigrationJob);
            _callGenerateSshScript = clientHelper.BuildApiCall<GenerateSshScriptRequest, SshScript>(grpcClient.GenerateSshScriptAsync, grpcClient.GenerateSshScript, effectiveSettings.GenerateSshScriptSettings).WithGoogleRequestParam("migration_job", request => request.MigrationJob);
            Modify_ApiCall(ref _callGenerateSshScript);
            Modify_GenerateSshScriptApiCall(ref _callGenerateSshScript);
            _callListConnectionProfiles = clientHelper.BuildApiCall<ListConnectionProfilesRequest, ListConnectionProfilesResponse>(grpcClient.ListConnectionProfilesAsync, grpcClient.ListConnectionProfiles, effectiveSettings.ListConnectionProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConnectionProfiles);
            Modify_ListConnectionProfilesApiCall(ref _callListConnectionProfiles);
            _callGetConnectionProfile = clientHelper.BuildApiCall<GetConnectionProfileRequest, ConnectionProfile>(grpcClient.GetConnectionProfileAsync, grpcClient.GetConnectionProfile, effectiveSettings.GetConnectionProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnectionProfile);
            Modify_GetConnectionProfileApiCall(ref _callGetConnectionProfile);
            _callCreateConnectionProfile = clientHelper.BuildApiCall<CreateConnectionProfileRequest, lro::Operation>(grpcClient.CreateConnectionProfileAsync, grpcClient.CreateConnectionProfile, effectiveSettings.CreateConnectionProfileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConnectionProfile);
            Modify_CreateConnectionProfileApiCall(ref _callCreateConnectionProfile);
            _callUpdateConnectionProfile = clientHelper.BuildApiCall<UpdateConnectionProfileRequest, lro::Operation>(grpcClient.UpdateConnectionProfileAsync, grpcClient.UpdateConnectionProfile, effectiveSettings.UpdateConnectionProfileSettings).WithGoogleRequestParam("connection_profile.name", request => request.ConnectionProfile?.Name);
            Modify_ApiCall(ref _callUpdateConnectionProfile);
            Modify_UpdateConnectionProfileApiCall(ref _callUpdateConnectionProfile);
            _callDeleteConnectionProfile = clientHelper.BuildApiCall<DeleteConnectionProfileRequest, lro::Operation>(grpcClient.DeleteConnectionProfileAsync, grpcClient.DeleteConnectionProfile, effectiveSettings.DeleteConnectionProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConnectionProfile);
            Modify_DeleteConnectionProfileApiCall(ref _callDeleteConnectionProfile);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListMigrationJobsApiCall(ref gaxgrpc::ApiCall<ListMigrationJobsRequest, ListMigrationJobsResponse> call);

        partial void Modify_GetMigrationJobApiCall(ref gaxgrpc::ApiCall<GetMigrationJobRequest, MigrationJob> call);

        partial void Modify_CreateMigrationJobApiCall(ref gaxgrpc::ApiCall<CreateMigrationJobRequest, lro::Operation> call);

        partial void Modify_UpdateMigrationJobApiCall(ref gaxgrpc::ApiCall<UpdateMigrationJobRequest, lro::Operation> call);

        partial void Modify_DeleteMigrationJobApiCall(ref gaxgrpc::ApiCall<DeleteMigrationJobRequest, lro::Operation> call);

        partial void Modify_StartMigrationJobApiCall(ref gaxgrpc::ApiCall<StartMigrationJobRequest, lro::Operation> call);

        partial void Modify_StopMigrationJobApiCall(ref gaxgrpc::ApiCall<StopMigrationJobRequest, lro::Operation> call);

        partial void Modify_ResumeMigrationJobApiCall(ref gaxgrpc::ApiCall<ResumeMigrationJobRequest, lro::Operation> call);

        partial void Modify_PromoteMigrationJobApiCall(ref gaxgrpc::ApiCall<PromoteMigrationJobRequest, lro::Operation> call);

        partial void Modify_VerifyMigrationJobApiCall(ref gaxgrpc::ApiCall<VerifyMigrationJobRequest, lro::Operation> call);

        partial void Modify_RestartMigrationJobApiCall(ref gaxgrpc::ApiCall<RestartMigrationJobRequest, lro::Operation> call);

        partial void Modify_GenerateSshScriptApiCall(ref gaxgrpc::ApiCall<GenerateSshScriptRequest, SshScript> call);

        partial void Modify_ListConnectionProfilesApiCall(ref gaxgrpc::ApiCall<ListConnectionProfilesRequest, ListConnectionProfilesResponse> call);

        partial void Modify_GetConnectionProfileApiCall(ref gaxgrpc::ApiCall<GetConnectionProfileRequest, ConnectionProfile> call);

        partial void Modify_CreateConnectionProfileApiCall(ref gaxgrpc::ApiCall<CreateConnectionProfileRequest, lro::Operation> call);

        partial void Modify_UpdateConnectionProfileApiCall(ref gaxgrpc::ApiCall<UpdateConnectionProfileRequest, lro::Operation> call);

        partial void Modify_DeleteConnectionProfileApiCall(ref gaxgrpc::ApiCall<DeleteConnectionProfileRequest, lro::Operation> call);

        partial void OnConstruction(DataMigrationService.DataMigrationServiceClient grpcClient, DataMigrationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataMigrationService client</summary>
        public override DataMigrationService.DataMigrationServiceClient GrpcClient { get; }

        partial void Modify_ListMigrationJobsRequest(ref ListMigrationJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMigrationJobRequest(ref GetMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMigrationJobRequest(ref CreateMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMigrationJobRequest(ref UpdateMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMigrationJobRequest(ref DeleteMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartMigrationJobRequest(ref StartMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopMigrationJobRequest(ref StopMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeMigrationJobRequest(ref ResumeMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PromoteMigrationJobRequest(ref PromoteMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_VerifyMigrationJobRequest(ref VerifyMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestartMigrationJobRequest(ref RestartMigrationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateSshScriptRequest(ref GenerateSshScriptRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConnectionProfilesRequest(ref ListConnectionProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectionProfileRequest(ref GetConnectionProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConnectionProfileRequest(ref CreateConnectionProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConnectionProfileRequest(ref UpdateConnectionProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConnectionProfileRequest(ref DeleteConnectionProfileRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MigrationJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobs(ListMigrationJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMigrationJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMigrationJobsRequest, ListMigrationJobsResponse, MigrationJob>(_callListMigrationJobs, request, callSettings);
        }

        /// <summary>
        /// Lists migration jobs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMigrationJobsResponse, MigrationJob> ListMigrationJobsAsync(ListMigrationJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMigrationJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMigrationJobsRequest, ListMigrationJobsResponse, MigrationJob>(_callListMigrationJobs, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MigrationJob GetMigrationJob(GetMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMigrationJobRequest(ref request, ref callSettings);
            return _callGetMigrationJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MigrationJob> GetMigrationJobAsync(GetMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMigrationJobRequest(ref request, ref callSettings);
            return _callGetMigrationJob.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMigrationJob</c>.</summary>
        public override lro::OperationsClient CreateMigrationJobOperationsClient { get; }

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> CreateMigrationJob(CreateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callCreateMigrationJob.Sync(request, callSettings), CreateMigrationJobOperationsClient);
        }

        /// <summary>
        /// Creates a new migration job in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> CreateMigrationJobAsync(CreateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callCreateMigrationJob.Async(request, callSettings).ConfigureAwait(false), CreateMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMigrationJob</c>.</summary>
        public override lro::OperationsClient UpdateMigrationJobOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> UpdateMigrationJob(UpdateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callUpdateMigrationJob.Sync(request, callSettings), UpdateMigrationJobOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> UpdateMigrationJobAsync(UpdateMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callUpdateMigrationJob.Async(request, callSettings).ConfigureAwait(false), UpdateMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMigrationJob</c>.</summary>
        public override lro::OperationsClient DeleteMigrationJobOperationsClient { get; }

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMigrationJob(DeleteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMigrationJob.Sync(request, callSettings), DeleteMigrationJobOperationsClient);
        }

        /// <summary>
        /// Deletes a single migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigrationJobAsync(DeleteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMigrationJob.Async(request, callSettings).ConfigureAwait(false), DeleteMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartMigrationJob</c>.</summary>
        public override lro::OperationsClient StartMigrationJobOperationsClient { get; }

        /// <summary>
        /// Start an already created migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> StartMigrationJob(StartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callStartMigrationJob.Sync(request, callSettings), StartMigrationJobOperationsClient);
        }

        /// <summary>
        /// Start an already created migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> StartMigrationJobAsync(StartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callStartMigrationJob.Async(request, callSettings).ConfigureAwait(false), StartMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopMigrationJob</c>.</summary>
        public override lro::OperationsClient StopMigrationJobOperationsClient { get; }

        /// <summary>
        /// Stops a running migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> StopMigrationJob(StopMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callStopMigrationJob.Sync(request, callSettings), StopMigrationJobOperationsClient);
        }

        /// <summary>
        /// Stops a running migration job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> StopMigrationJobAsync(StopMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callStopMigrationJob.Async(request, callSettings).ConfigureAwait(false), StopMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ResumeMigrationJob</c>.</summary>
        public override lro::OperationsClient ResumeMigrationJobOperationsClient { get; }

        /// <summary>
        /// Resume a migration job that is currently stopped and is resumable (was
        /// stopped during CDC phase).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> ResumeMigrationJob(ResumeMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callResumeMigrationJob.Sync(request, callSettings), ResumeMigrationJobOperationsClient);
        }

        /// <summary>
        /// Resume a migration job that is currently stopped and is resumable (was
        /// stopped during CDC phase).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> ResumeMigrationJobAsync(ResumeMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callResumeMigrationJob.Async(request, callSettings).ConfigureAwait(false), ResumeMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PromoteMigrationJob</c>.</summary>
        public override lro::OperationsClient PromoteMigrationJobOperationsClient { get; }

        /// <summary>
        /// Promote a migration job, stopping replication to the destination and
        /// promoting the destination to be a standalone database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> PromoteMigrationJob(PromoteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callPromoteMigrationJob.Sync(request, callSettings), PromoteMigrationJobOperationsClient);
        }

        /// <summary>
        /// Promote a migration job, stopping replication to the destination and
        /// promoting the destination to be a standalone database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> PromoteMigrationJobAsync(PromoteMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callPromoteMigrationJob.Async(request, callSettings).ConfigureAwait(false), PromoteMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>VerifyMigrationJob</c>.</summary>
        public override lro::OperationsClient VerifyMigrationJobOperationsClient { get; }

        /// <summary>
        /// Verify a migration job, making sure the destination can reach the source
        /// and that all configuration and prerequisites are met.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> VerifyMigrationJob(VerifyMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callVerifyMigrationJob.Sync(request, callSettings), VerifyMigrationJobOperationsClient);
        }

        /// <summary>
        /// Verify a migration job, making sure the destination can reach the source
        /// and that all configuration and prerequisites are met.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> VerifyMigrationJobAsync(VerifyMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callVerifyMigrationJob.Async(request, callSettings).ConfigureAwait(false), VerifyMigrationJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RestartMigrationJob</c>.</summary>
        public override lro::OperationsClient RestartMigrationJobOperationsClient { get; }

        /// <summary>
        /// Restart a stopped or failed migration job, resetting the destination
        /// instance to its original state and starting the migration process from
        /// scratch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigrationJob, OperationMetadata> RestartMigrationJob(RestartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestartMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(_callRestartMigrationJob.Sync(request, callSettings), RestartMigrationJobOperationsClient);
        }

        /// <summary>
        /// Restart a stopped or failed migration job, resetting the destination
        /// instance to its original state and starting the migration process from
        /// scratch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigrationJob, OperationMetadata>> RestartMigrationJobAsync(RestartMigrationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestartMigrationJobRequest(ref request, ref callSettings);
            return new lro::Operation<MigrationJob, OperationMetadata>(await _callRestartMigrationJob.Async(request, callSettings).ConfigureAwait(false), RestartMigrationJobOperationsClient);
        }

        /// <summary>
        /// Generate a SSH configuration script to configure the reverse SSH
        /// connectivity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SshScript GenerateSshScript(GenerateSshScriptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateSshScriptRequest(ref request, ref callSettings);
            return _callGenerateSshScript.Sync(request, callSettings);
        }

        /// <summary>
        /// Generate a SSH configuration script to configure the reverse SSH
        /// connectivity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SshScript> GenerateSshScriptAsync(GenerateSshScriptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateSshScriptRequest(ref request, ref callSettings);
            return _callGenerateSshScript.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve a list of all connection profiles in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public override gax::PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfiles(ListConnectionProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectionProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConnectionProfilesRequest, ListConnectionProfilesResponse, ConnectionProfile>(_callListConnectionProfiles, request, callSettings);
        }

        /// <summary>
        /// Retrieve a list of all connection profiles in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectionProfile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> ListConnectionProfilesAsync(ListConnectionProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectionProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConnectionProfilesRequest, ListConnectionProfilesResponse, ConnectionProfile>(_callListConnectionProfiles, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConnectionProfile GetConnectionProfile(GetConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionProfileRequest(ref request, ref callSettings);
            return _callGetConnectionProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConnectionProfile> GetConnectionProfileAsync(GetConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionProfileRequest(ref request, ref callSettings);
            return _callGetConnectionProfile.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateConnectionProfile</c>.</summary>
        public override lro::OperationsClient CreateConnectionProfileOperationsClient { get; }

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConnectionProfile, OperationMetadata> CreateConnectionProfile(CreateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionProfile, OperationMetadata>(_callCreateConnectionProfile.Sync(request, callSettings), CreateConnectionProfileOperationsClient);
        }

        /// <summary>
        /// Creates a new connection profile in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> CreateConnectionProfileAsync(CreateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionProfile, OperationMetadata>(await _callCreateConnectionProfile.Async(request, callSettings).ConfigureAwait(false), CreateConnectionProfileOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateConnectionProfile</c>.</summary>
        public override lro::OperationsClient UpdateConnectionProfileOperationsClient { get; }

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConnectionProfile, OperationMetadata> UpdateConnectionProfile(UpdateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionProfile, OperationMetadata>(_callUpdateConnectionProfile.Sync(request, callSettings), UpdateConnectionProfileOperationsClient);
        }

        /// <summary>
        /// Update the configuration of a single connection profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConnectionProfile, OperationMetadata>> UpdateConnectionProfileAsync(UpdateConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectionProfile, OperationMetadata>(await _callUpdateConnectionProfile.Async(request, callSettings).ConfigureAwait(false), UpdateConnectionProfileOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteConnectionProfile</c>.</summary>
        public override lro::OperationsClient DeleteConnectionProfileOperationsClient { get; }

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectionProfile(DeleteConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteConnectionProfile.Sync(request, callSettings), DeleteConnectionProfileOperationsClient);
        }

        /// <summary>
        /// Deletes a single Database Migration Service connection profile.
        /// A connection profile can only be deleted if it is not in use by any
        /// active migration jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectionProfileAsync(DeleteConnectionProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectionProfileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteConnectionProfile.Async(request, callSettings).ConfigureAwait(false), DeleteConnectionProfileOperationsClient);
        }
    }

    public partial class ListMigrationJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectionProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMigrationJobsResponse : gaxgrpc::IPageResponse<MigrationJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MigrationJob> GetEnumerator() => MigrationJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConnectionProfilesResponse : gaxgrpc::IPageResponse<ConnectionProfile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConnectionProfile> GetEnumerator() => ConnectionProfiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataMigrationService
    {
        public partial class DataMigrationServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
